using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyUCommerceApp.Website.Models
{
	public class PaymentViewModel
	{
		public PaymentViewModel()
		{
			AvailablePaymentMethods = new List<SelectListItem>();	
		}

		public IList<SelectListItem> AvailablePaymentMethods { get; set; }

		public int SelectedPaymentMethodId { get; set; }
	}
}