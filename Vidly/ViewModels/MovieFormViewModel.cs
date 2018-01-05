using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime? ReleaseDate { get; set; }
        
        [Display(Name = "Number in Stock")]
        [Range(1, 5000)]
        [Required]
        public int? NumInStock { get; set; }

        public string Title {
            get
            {
                if (this.Id == 0)
                {
                    return "New Movie";
                }

                return "Edit Movie";
            }
        }

        public MovieFormViewModel()
        {
            this.Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            this.Id = movie.Id;
            this.Name = movie.Name;
            this.ReleaseDate = movie.ReleaseDate;
            this.NumInStock = movie.NumInStock;
            this.GenreId = movie.GenreId;
        }
    }
}