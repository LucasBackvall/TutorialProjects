using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models.ViewModels
{
	public class CustomerDetailsViewModel
	{
		// Since this view is supposed to give the details about
		// a single customer maybe I don't need a special ViewModel.
		// I created it anyways if I decide to pass more data to the
		// Details view.
		public Customer Customer { get; set; }
	}
}