using Microsoft.AspNetCore.Mvc;
namespace MyFirstDotNetApp.Controllers;

public class HomeController : Controller
{
    [Route("sayHello")]
    public String Index()
    {
        return "Hello From method 1";
    }
}
