using Microsoft.AspNetCore.Mvc;

namespace edilData.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEmployeeForm()
        {
            return View();
        }
    }
}
