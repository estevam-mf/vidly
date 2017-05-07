using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            var model = _context.Customers.Include(x => x.MembershipType).ToList();
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = _context.Customers.Include(x => x.MembershipType).Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }

    }
}