using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult Index()
        {
            var model = _context.Movies.Include(x => x.Genre).ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _context.Movies.Include(x => x.Genre).Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

        public ActionResult New()
        {
            var listGenresModel = _context.Genres.ToList();
            var model = new MovieFormViewModel()
            {
                GenreModelList = listGenresModel,
                MovieModel = null
            };

            return View("MovieForm", model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(MovieModel MovieModel)
        {
            if (MovieModel.Id == 0)
            {
                MovieModel.DateAdded = DateTime.Now;
                _context.Movies.Add(MovieModel);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(x => x.Id == MovieModel.Id);
                movieInDb.GenreModelId = MovieModel.GenreModelId;
                movieInDb.Name = MovieModel.Name;
                movieInDb.ReleaseDate = MovieModel.ReleaseDate;
                movieInDb.NumberInStock = MovieModel.NumberInStock;
            }
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(x => x.Id == id);
            var listGenresModel = _context.Genres.ToList();

            var movieFormViewModel = new MovieFormViewModel()
            {
                GenreModelList = listGenresModel,
                MovieModel = movieInDb
            };

            if (movieInDb == null)
                return HttpNotFound();
            else
            return View("MovieForm", movieFormViewModel);
        }
    }
}