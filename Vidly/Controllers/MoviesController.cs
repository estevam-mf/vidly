using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

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
    }
}