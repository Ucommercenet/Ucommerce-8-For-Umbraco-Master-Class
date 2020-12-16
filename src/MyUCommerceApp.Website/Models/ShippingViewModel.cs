using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyUCommerceApp.Website.Models
{
	public class ShippingViewModel
	{
		public ShippingViewModel()
		{
			AvailableShippingMethods = new List<SelectListItem>();
		}
		public IList<SelectListItem> AvailableShippingMethods { get; set; }

		public int SelectedShippingMethodId { get; set; }
	}
}