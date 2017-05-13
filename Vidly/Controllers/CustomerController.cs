using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

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

        public ActionResult CostumerForm(CustomerFormViewModel newCostumerViewModel)
        {
            return View(newCostumerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(CustomerModel CustomerModel)
        {
            if (!ModelState.IsValid)
            {
                var CustomerFormViewModel = new CustomerFormViewModel()
                {
                    MembershipType = _context.MembershipType.ToList(),
                    CustomerModel = CustomerModel
                };
                return View("CostumerForm", CustomerFormViewModel);
            }

            if (CustomerModel.Id == 0)
                _context.Customers.Add(CustomerModel);
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(x => x.Id == CustomerModel.Id);
                customerInDb.BirthdayDate = CustomerModel.BirthdayDate;
                customerInDb.IsSubscribedToNewsLetter = CustomerModel.IsSubscribedToNewsLetter;
                customerInDb.MembershipTypeId = CustomerModel.MembershipTypeId;
                customerInDb.Name = CustomerModel.Name;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }

        public ActionResult Edit(int id)
        {
            var costumer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (costumer == null)
                return HttpNotFound();

            var CustomerFormViewModel = new CustomerFormViewModel()
            {
                CustomerModel = costumer,
                MembershipType = _context.MembershipType.ToList()
            };

            return View("CostumerForm", CustomerFormViewModel);
        }
    }
}