using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieModel
    {
        [Required(ErrorMessage = "Please enter movie's name.")]
        public string Name { get; set; }

        public int Id { get; set; }

        public GenreModel Genre { get; set; }

        [Display(Name="Genre")]
        [Required(ErrorMessage = "Please enter movie's gender.")]
        public int GenreModelId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter movie's release date.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Number In Stock")]
        [Required(ErrorMessage = "Please enter movie's number in stock.")]
        public int NumberInStock { get; set; }
    }
}