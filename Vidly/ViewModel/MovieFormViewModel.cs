using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        [Required(ErrorMessage = "Please enter movie's name.")]
        public string Name { get; set; }

        public int Id { get; set; }

        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter movie's gender.")]
        public int GenreModelId { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter movie's release date.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number In Stock")]
        [Required(ErrorMessage = "Please enter movie's number in stock.")]
        public int? NumberInStock { get; set; }

        public IEnumerable<GenreModel> GenreModelList { get; set; }

        public string Title()
        {
            return Id == 0 ? "New Movie" : "Edit Movie";
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(MovieModel movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreModelId = movie.GenreModelId;
        }
    }
}