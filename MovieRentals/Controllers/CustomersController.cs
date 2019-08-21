using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentals.Models;
using MovieRentals.Models.ViewModels;

namespace MovieRentals.Controllers
{
	public class CustomersController : Controller
	{
		private List<Customer> CustomerList()
		{
			var customers = new List<Customer> 
				{
					new Customer { Id = 0, Name = "Stefan Löven" },
					new Customer { Id = 1, Name = "Donald Trump" }
				};
			
			return customers;
		}
		

		public ActionResult Index()
		{
			var viewModel = new CustomerIndexViewModel { Customers = CustomerList() };
			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
			var viewModel = new CustomerDetailsViewModel { Customer = CustomerList()[id] };
			return View(viewModel);
		}
	}
}