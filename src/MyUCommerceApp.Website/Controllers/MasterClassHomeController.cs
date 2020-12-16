using System.Web.Mvc;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassHomeController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
		public ActionResult Index()
		{
			return View("/views/mc/frontpage.cshtml");
		}
	}
}