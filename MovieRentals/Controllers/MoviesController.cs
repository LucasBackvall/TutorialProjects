using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentals.Models;

namespace MovieRentals.Controllers
{
	public class MoviesController : Controller
	{
		// Example of routing with default routing
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Lion King live action remake" };
			return View(movie);
		}

		public ActionResult Edit(int id)
		{
			return Content("id=" + id);
		}
		
		public ActionResult Index(int? pageIndex, string sortBy)
		{
			if (!pageIndex.HasValue)
				pageIndex = 1;
			if (String.IsNullOrWhiteSpace(sortBy))
				sortBy = "Name";
			return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
		}

		// Special case routing
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(String.Format("Movies released {0}/{1}", year, month));
		}

	}
}