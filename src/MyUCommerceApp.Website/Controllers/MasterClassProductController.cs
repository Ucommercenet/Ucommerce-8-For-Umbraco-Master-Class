using System.Collections.Generic;
using System.Web.Mvc;
using UCommerce.EntitiesV2;
using MyUCommerceApp.Website.Models;
using UCommerce.Api;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassProductController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
		{
			ProductViewModel productModel = new ProductViewModel();

            return View("/views/mc/product.cshtml", productModel);
		}

		private IList<ProductViewModel> MapVariants(ICollection<Product> variants)
		{
			var variantModels = new List<ProductViewModel>();

			return variantModels;
		}

		[HttpPost]
		public ActionResult Index(AddToBasketViewModel model)
		{
            return Index();
        }
    }
}