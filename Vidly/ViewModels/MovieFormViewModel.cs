using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        public Movie Movie { get; set; }
        public string Title {
            get
            {
                if (this.Movie == null ||
                    this.Movie.Id == 0)
                {
                    return "New Movie";
                }

                return "Edit Movie";
            }
        }
    }
}