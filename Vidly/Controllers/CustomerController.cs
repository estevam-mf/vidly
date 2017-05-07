using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            var model = new List<CustomerModel>()
            {
                new CustomerModel {Name = "Estevam", Id = 0 },
                new CustomerModel {Name = "Valéria", Id = 1 }
            };
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var customerList = new List<CustomerModel>()
            {
                new CustomerModel {Name = "Estevam", Id = 0 },
                new CustomerModel {Name = "Valéria", Id = 1 }
            };
            var model = customerList.Where(x => x.Id == id).FirstOrDefault();
            return View(model);
        }
    }
}