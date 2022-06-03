using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models.ViewModels
{
    public class ListMoviesViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Ratings { get; set; }
        public int ratingID { get; set; }

    }
}
