using Microsoft.AspNetCore.Mvc;
using MvcTask1App.Models;

namespace MvcTask1App.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult SingleEmpData()
        {
            Employee employee = new Employee()
            { EmployeeId = 1, FirstName = "Divya", LastName = "Sales", Gender="Female"};
            return View("SingleEmpData", employee);
        }
        public IActionResult EmployeeInfo()
        {
            List<Employee> liemployee =Employee.GetData();
            return View(liemployee);
            
        }
        public IActionResult InsertData()
        {
            return View();
        }
    }
}
