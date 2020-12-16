using System.Collections.Generic;
using System.Web.Mvc;
using UCommerce.EntitiesV2;
using MyUCommerceApp.Website.Models;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassCategoryController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
        {
            var categoryViewModel = new CategoryViewModel();

            return View("/views/mc/category.cshtml", categoryViewModel);
        }

        private IList<ProductViewModel> MapProducts(ICollection<Product> productsInCategory)
        {
            IList<ProductViewModel> productViews = new List<ProductViewModel>();

            return productViews;
        }
    }
}