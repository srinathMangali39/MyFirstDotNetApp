using Microsoft.AspNetCore.Mvc;
namespace MyFirstDotNetApp.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ContentResult Method1()
    {
        //return new ContentResult()
        //{
        //    Content = "<h1>Hi i am srinath</h1>",
        //    ContentType = "text/html"
        //};
        return Content("Hi am different", "text/plain");
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
