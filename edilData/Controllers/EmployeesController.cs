using edilData.Models;
using Microsoft.AspNetCore.Mvc;

namespace edilData.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //pagina form aggiungi dipendente
        public IActionResult AddEmployeeForm()
        {
            return View();
        }

        // indirizzo per gestire il submit del form
        [HttpPost]
        public IActionResult AddEmployeeForm(string fname, string lname, string address, string fiscalcode, string conjugality, int children, string role)
        {
            var employee = new Employee()
            {
                FirstName = fname,
                LastName = lname,
                Address = address,
                FiscalCode = fiscalcode,
                Conjugality = conjugality,
                Children = children,
                Role = role
            };
            StaticDb._employee.Add(employee);
            return RedirectToAction("index");
        }
    }
}
