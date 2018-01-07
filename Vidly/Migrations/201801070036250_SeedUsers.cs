namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5c2682d6-8f12-424b-9c2f-856d0acd6e26', N'guest@vidly.com', 0, N'APHQNlryQZtSQhKP7BwsieK1TrEo48XGQrPui3/jT6tnMPTKNbrYUVgh8gvOtfQleA==', N'c0df88a8-bce3-4f11-b0d7-8465c783d7cd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'5fc63344-d40f-4794-8e63-595404995167', N'admin@vidly.com', 0, N'AMdLZn6ox2nRvX9GHBlWHahO9QLCtaVh+GgPl+fQbqAA2aGuz3DgLhmDZKH/LSgWEQ==', N'b4bc1541-ae15-4951-893c-a3443add4540', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd4860bf5-aba4-473b-b65b-a1eee3dca027', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'5fc63344-d40f-4794-8e63-595404995167', N'd4860bf5-aba4-473b-b65b-a1eee3dca027')
");
        }
        
        public override void Down()
        {
        }
    }
}
