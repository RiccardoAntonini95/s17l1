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
    }
}
