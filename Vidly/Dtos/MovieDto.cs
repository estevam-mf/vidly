using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        [Required(ErrorMessage = "Please enter movie's name.")]
        public string Name { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movie's gender.")]
        public int GenreModelId { get; set; }

        public GenreDto Genre { get; set; }

        [Required(ErrorMessage = "Please enter movie's release date.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter movie's number in stock.")]
        public int NumberInStock { get; set; }
    }
}