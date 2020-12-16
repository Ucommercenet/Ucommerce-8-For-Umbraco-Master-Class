using System.Linq;
using System.Web.Mvc;
using UCommerce.Api;
using UCommerce.EntitiesV2;
using MyUCommerceApp.Website.Models;

namespace MyUCommerceApp.Website.Controllers
{
	public class MasterClassPaymentController : Umbraco.Web.Mvc.RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
		{
			var paymentViewModel = new PaymentViewModel();

			PurchaseOrder basket = TransactionLibrary.GetBasket(false).PurchaseOrder;

			Country shippingCountry = TransactionLibrary.GetShippingInformation().Country;

			var availablePaymentMethods = TransactionLibrary.GetPaymentMethods(shippingCountry);

			var existingPayment = basket.Payments.FirstOrDefault();

			paymentViewModel.SelectedPaymentMethodId = existingPayment != null
				? existingPayment.PaymentMethod.PaymentMethodId
				: -1;

			foreach (var availablePaymentMethod in availablePaymentMethods)
			{
				var option = new SelectListItem();
				option.Text = availablePaymentMethod.Name;
				option.Value = availablePaymentMethod.PaymentMethodId.ToString();
				option.Selected = availablePaymentMethod.PaymentMethodId == paymentViewModel.SelectedPaymentMethodId;

				paymentViewModel.AvailablePaymentMethods.Add(option);
			}

			return View("/Views/mc/Payment.cshtml", paymentViewModel);
		}

		[HttpPost]
		public ActionResult Index(PaymentViewModel payment)
		{
			TransactionLibrary.CreatePayment(
				paymentMethodId: payment.SelectedPaymentMethodId, 
				requestPayment: false, 
				amount: -1, 
				overwriteExisting: true);

			TransactionLibrary.ExecuteBasketPipeline();

			return Redirect("/preview");
		}

	}
}