using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<MovieModel>()
            {
                new MovieModel {Name = "Her", Id = 0 },
                new MovieModel {Name = "Estômago", Id = 1 }
            };
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var customerList = new List<MovieModel>()
            {
                new MovieModel {Name = "Her", Id = 0 },
                new MovieModel {Name = "Estômago", Id = 1 }
            };
            var model = customerList.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }
    }
}