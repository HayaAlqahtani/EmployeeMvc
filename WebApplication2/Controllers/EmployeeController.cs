using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> list = new List<Employee>
           {
                new Employee {EmployeeId  = 1, FirstName ="haya", LastName="alqahtani", Department= "ce", Email="haya@email" },
                new Employee {EmployeeId  = 2, FirstName ="amar", LastName="alfailakawi", Department= "ce", Email="amar@email" }


           };
            ViewData["data"]=list;
            return View();
        }
    }
}
