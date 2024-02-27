using edilData.Models;
using Microsoft.AspNetCore.Mvc;

namespace edilData.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddPaymentForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPaymentForm(DateOnly paymentPeriod, double paymentAmount, string paymentType)
        {
            var payment = new Payment()
            {
                PaymentPeriod = paymentPeriod,
                PaymentAmount = paymentAmount,
                PaymentType = paymentType
            };
            StaticDb._payments.Add(payment);
            return RedirectToAction("index");
        }
    }
}
