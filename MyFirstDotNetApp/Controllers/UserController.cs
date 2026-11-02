using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetApp.Models;

namespace MyFirstDotNetApp.Controllers;

public class UserController : Controller
{
    [Route("/users/{name?}/{age:int}")]
    public IActionResult UserDetails([FromQuery] string? name, [FromRoute] int age)
    {
        return Json(new User()
        {
            Name = name,
            Age = age
        });
    }

    [Route("users")]
    public IActionResult CreateUserDetails(User user)
    {
        return Content(user.ToString());
    }
}
