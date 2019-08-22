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

		public ActionResult Index()
		{
			var viewModel = new CustomerIndexViewModel { Customers = CustomerDatabase.Customers() };
			return View(viewModel);
		}

		public ActionResult Details(int id)
		{
			var viewModel = new CustomerDetailsViewModel { Customer = CustomerDatabase.Customers()[id] };
			return View(viewModel);
		}
	}
}