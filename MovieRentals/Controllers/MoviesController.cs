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

		// Special case routing.
		// Year is a int > 0 with 4 digits. Month is a in between 1 and 12 with 2 digits.
		[Route("movies/released/{year:regex(\\d{4}):min(0)}/{month:regex(\\d{2}):range(1, 12)}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(String.Format("Movies released {0}/{1}", year, month));
		}

	}
}