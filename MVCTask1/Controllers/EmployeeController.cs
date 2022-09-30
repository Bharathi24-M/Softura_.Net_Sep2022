using Microsoft.AspNetCore.Mvc;
using MvcTask1App.Models;

namespace MvcTask1App.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            { EmpId = 1, EmpName = "Divya", DepartmentName = "Sales", Salary=50000};
            return View("Index", employee);
        }
    }
}
