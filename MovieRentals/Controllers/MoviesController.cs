using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRentals.Models;
using MovieRentals.Models.ViewModels;

namespace MovieRentals.Controllers
{
	public class MoviesController : Controller
	{
		// Example of routing with default routing
		public ActionResult Random()
		{
			var movie = new Movie() { Name = "Lion King live action remake" };
			var customers = new List<Customer>
			{
				new Customer { Name = "Stefan Löven" },
				new Customer { Name = "Donald Trump" }
			};
			var viewModel = new RandomMovieViewModel
			{
				Movie = movie,
				Customers = customers
			};
			return View(viewModel);
		}

		public ActionResult Index(int? pageIndex, string sortBy)
		{
			// Page index and sort by is currently unused
			if (!pageIndex.HasValue)
				pageIndex = 1;
			if (String.IsNullOrWhiteSpace(sortBy))
				sortBy = "Name";
			var movies = new List<Movie>
			{
				new Movie { Id = 0, Name = "The Lion King: Live action remake" },
				new Movie { Id = 1, Name = "Terminator" },
				new Movie { Id = 2, Name = "Terminator 3" }
			};
			var viewModel = new MovieIndexViewModel { Movies = movies };
			return View(viewModel);
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