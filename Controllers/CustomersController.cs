using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private MyDBContext _context;


        public CustomersController()
        {
            _context = new MyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult All()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            AllCustomersViewModel viewModel = new AllCustomersViewModel();
            viewModel.Customers = customers;

            return View(viewModel);
        }

        public ActionResult One(int id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipType).ToList().SingleOrDefault(p => p.Id == id);

            if (customer == null)
                return new HttpNotFoundResult();
            else
                return View(customer);
        }
    }
}