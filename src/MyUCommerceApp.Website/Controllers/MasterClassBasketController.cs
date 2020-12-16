using System.Web.Mvc;
using MyUCommerceApp.Website.Models;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassBasketController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
        {
            var basketModel = new PurchaseOrderViewModel();

            return View("/Views/mc/Basket.cshtml", basketModel);
        }

        [HttpPost]
        public ActionResult Index(PurchaseOrderViewModel model)
        {
            return Redirect(this.CurrentPage.Url);
        }
    }
}