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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book bk)
        {
            bool res=bbl.AddBook(bk);
            if(res)
            {
                ViewData["msg"] = "Added SuccesFully";
                return View("Success",bk);
            }
            return View();
            
        }

        [HttpGet]
        public IActionResult Update(int BookId)
        {
            Book? bk=bbl.getBook(BookId);
            return View(bk);

        }
        [HttpPost]
        public IActionResult Update(Book bk)
        {
            bool res=bbl.Update(bk);
            if (res)
            {
                ViewData["msg"] = "Updated SuccesFully";
                return View("Success", bk);
            }
            return View(bk);

        }

        public IActionResult Delete(int BookId)
        {
            Book bk = bbl.Delete(BookId);
            if (bk!=null)
            {
                ViewData["msg"] = "Deleted SuccesFully";
                return View("Success",bk);
            }
            return View("Index");
        }

    }
}
