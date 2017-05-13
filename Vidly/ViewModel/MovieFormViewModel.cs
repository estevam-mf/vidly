using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreModel> GenreModelList { get; set; }
        public MovieModel MovieModel { get; set; }
    }
}