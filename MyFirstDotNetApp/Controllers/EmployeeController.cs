using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetApp.Models;

namespace MyFirstDotNetApp.Controllers;

public class EmployeeController : Controller
{
    [Route("employee")] 
    public IActionResult CreateEmployee(Employee employee)
    {
        if (!ModelState.IsValid)
        {
            List<string> allErrors = new List<string>();
            foreach(var value in ModelState.Values)
            {
                foreach(var error in value.Errors)
                {
                    allErrors.Add(error.ErrorMessage);
                }
            }
            return BadRequest(string.Join("\n",allErrors));
        }
        return Json(employee);
    }
}
