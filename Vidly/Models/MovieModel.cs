using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieModel
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public GenreModel Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public int GenreModelId { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        public int NumberInStock { get; set; }
    }
}