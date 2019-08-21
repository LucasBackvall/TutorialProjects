using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MovieRentals.Models;

namespace MovieRentals.Models.ViewModels
{
	public class MovieIndexViewModel
	{
		public List<Movie> Movies { get; set; }
	}
}