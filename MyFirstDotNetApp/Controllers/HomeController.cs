using Microsoft.AspNetCore.Mvc;
namespace MyFirstDotNetApp.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public String Index()
    {
        return "Hello From method 1";
    }

    [Route("about")]
    public String About()
    {
        return "Hello From About 1";
    }

    [Route("contact/{mobile:regex(^\\d{{10}}$)}")]
    public String Home()
    {
        return "this is from contact";
    }

}
