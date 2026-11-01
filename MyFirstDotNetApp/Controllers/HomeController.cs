using Microsoft.AspNetCore.Mvc;
using MyFirstDotNetApp.Models;
namespace MyFirstDotNetApp.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public IActionResult Method1()
    {
        //return new ContentResult()
        //{
        //    Content = "<h1>Hi i am srinath</h1>",
        //    ContentType = "text/html"
        //};
        //return Content("Hi am different", "text/plain");
        return BadRequest("Hi am different");
    }

    [Route("about")]
    public IActionResult About()
    {
        return NotFound(" i am not found");
    }

    [Route("contact/{mobile:regex(^\\d{{10}}$)}")]
    public String Home()
    {
        return "this is from contact";
    }

    [Route("person")]
    public IActionResult GetPersonData()
    {
        Person person = new Person()
        {
            Id = Guid.NewGuid(),
            FirstName = "Srinath",
            LastName = "Mangali",
            Age = 24
        };

        return Unauthorized(person);
    }

    [Route("download-virtual")]
    public VirtualFileResult DownloadField()
    {
        //return new VirtualFileResult("/Denaurlen_Internship.pdf", "Application/pdf");
        return File("/Denaurlen_Internship.pdf", "Application/pdf");
    }

    [Route("download-physical")]
    public PhysicalFileResult DownloadField2()
    {
        //return new PhysicalFileResult(@"C:\Users\MangaliSrinath\source\repos\MyFirstDotNetApp\MyFirstDotNetApp\wwwroot\Denaurlen_Internship.pdf", "Application/pdf");
        return PhysicalFile(@"C:\Users\MangaliSrinath\source\repos\MyFirstDotNetApp\MyFirstDotNetApp\wwwroot\Denaurlen_Internship.pdf", "Application/pdf");

    }


    [Route("download-file")]
    public FileContentResult DownloadField3()
    {
        Byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\MangaliSrinath\source\repos\MyFirstDotNetApp\MyFirstDotNetApp\wwwroot\Denaurlen_Internship.pdf");
        //return new FileContentResult(bytes, "Application/pdf");
        return File(bytes, "Application/pdf");
    }

    [Route("items/book")]
    public IActionResult GetBookItem()
    {
        return new RedirectToActionResult("GetBookName", "Books", new { }, true);
        // return RedirectToAction("GetBookName", "Books",new { });
        //return RedirectToActionPermanent("GetBookName", "Books", new {});
    }

    [Route("items/book/{bookid:int}")]
    public IActionResult GetBookItemyId()
    {
        return new RedirectToActionResult("GetBookNameById", "Books", new { id = Convert.ToInt32(Request.RouteValues["bookid"]) }, true);
    }

    [Route("items/famous/book/{bookid:int}")]
    public IActionResult GetBookItemById()
    {
        int bid = Convert.ToInt32(Request.RouteValues["bookid"]);
        return new LocalRedirectResult($"/store/famous/bookName/{bid}");   // add true parameter for 301 status code 
        //return LocalRedirect($"/store/famous/bookName/{bid}");   
        //return LocalRedirectPermanent($"/store/famous/bookName/{bid}");   // for 301 status code
    }


    [Route("items/externalBooks")]
    public IActionResult GetExternalBooks()
    {
        return new RedirectResult("https://www.youtube.com/");   // add true parameter for 301 status code
        //return Redirect("https://www.youtube.com/");   
        //return RedirectPermanent("https://www.youtube.com/");   // for 301 status code
    }

}
