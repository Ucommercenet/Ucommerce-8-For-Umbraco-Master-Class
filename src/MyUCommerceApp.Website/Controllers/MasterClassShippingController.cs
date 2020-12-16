using System.Web.Mvc;
using MyUCommerceApp.Website.Models;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassShippingController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
        {
            var shippingModel = new ShippingViewModel();

            return View("/Views/mc/Shipping.cshtml", shippingModel);
        }

        [HttpPost]
        public ActionResult Index(ShippingViewModel shipping)
        {
            return Redirect("/payment");
		}
	}
}