using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieRentals
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			// Special route for MoviesByReleaseDate.
			// Constrained so a year must be 4 digits and month must be 2 digits.
			//  2200 /99 is still valid.
			routes.MapRoute(
				name: "MoviesByReleaseDate",
				url: "movies/released/{year}/{month}",
				defaults: new { controller = "Movies", action = "ByReleaseDate" },
				new { year = @"\d{4}", month = @"\d{2}" }
			);
			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
		}
	}
}
 