using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
	public class Movie
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class MovieDatabase
	{
		// This is in place of a database for testing purposes
		public static List<Movie> Movies()
		{
			var movies = new List<Movie>
			{
				new Movie { Id = 0, Name = "The Lion King: Live action remake" },
				new Movie { Id = 1, Name = "Terminator" },
				new Movie { Id = 2, Name = "Terminator 3" }
			};

			return movies;
		}
	}
}