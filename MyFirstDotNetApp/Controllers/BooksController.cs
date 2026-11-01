using Microsoft.AspNetCore.Mvc;

namespace MyFirstDotNetApp.Controllers;

public class BooksController : Controller
{
    [Route("store/bookName")]
    public IActionResult GetBookName()
    {
        return Content("Lean to start up", "text/plain");
    }

    [Route("store/bookName/{id:int}")]
    public IActionResult GetBookNameById()
    {
        int bookId = Convert.ToInt32(Request.RouteValues["id"]);
        if (bookId == 1)
        {
            return Content("atomic habits", "text/plain");
        }
        return Content("rich dad poor dad", "text/plain");
    }


    [Route("store/famous/bookName/{id:int}")]
    public IActionResult GetFamousBookNameById()
    {
        int bookId = Convert.ToInt32(Request.RouteValues["id"]);
        if (bookId == 1)
        {
            return Content("famous book 1", "text/plain");
        }
        return Content("least famous book", "text/plain");
    }
}
