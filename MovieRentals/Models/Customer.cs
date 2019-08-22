using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}

	public class CustomerDatabase
	{
		// This is temporary in place of a real database for testing purposes
		public static List<Customer> Customers()
		{
			var customers = new List<Customer>
			{
				new Customer { Id = 0, Name = "Stefan Löven" },
				new Customer { Id = 1, Name = "Donald Trump" }
			};
			return customers;
		}
	}
}