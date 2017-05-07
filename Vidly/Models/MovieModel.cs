using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public GenreModel Genre { get; set; }
        public int GenreModelId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int NumberInStock { get; set; }
    }
}