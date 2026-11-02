using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetApp.Models;

namespace MyFirstDotNetApp.Controllers;

public class EmployeeController : Controller
{
    [Route("employee")]
    public IActionResult CreateEmployee(Employee employee)
    {
        return View();
    }
}
