using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers); //this is the Model
        }

        // GET:
        public ActionResult Detail(int id)
        {
            var customer = GetCustomers().Where(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }

            //var customer = customers[id];

            return View(customer); //this is the Model
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Ygor Andreff"},
                new Customer { Id = 2, Name = "Daniel Arrieta" },
                new Customer { Id = 3, Name = "Danny Sejas" }
            };
        }
    }
}