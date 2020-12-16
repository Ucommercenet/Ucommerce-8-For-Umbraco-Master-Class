using System.Collections.Generic;
using System.Web.Mvc;
using MyUCommerceApp.Website.Models;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassPartialViewController : Umbraco.Web.Mvc.SurfaceController
    {
        public ActionResult CategoryNavigation()
        {
            var categoryNavigation = new CategoryNavigationViewModel();

            return View("/views/mc/PartialViews/CategoryNavigation.cshtml", categoryNavigation);
        }

        private IList<CategoryViewModel> MapCategories(ICollection<UCommerce.EntitiesV2.Category> categoriesToMap)
        {
            var categoriesToReturn = new List<CategoryViewModel>();

            return categoriesToReturn;
        }
    }
}