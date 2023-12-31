using BusinessLogic;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookManagementWeb.Controllers
{
    public class BookController : Controller
    {
        BookBL bbl=new BookBL();
        public IActionResult Index()
        {
            List<Book> blist=bbl.getAllBooks();
            return View(blist);
        }
    }
}
