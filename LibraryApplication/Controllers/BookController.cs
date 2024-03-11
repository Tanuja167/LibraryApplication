using LibraryApplication.Models;
using LibraryApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApplication.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService service;

        public BookController(IBookService service)
        {
            this.service = service;
        }


        // GET: BookController

       
        public ActionResult Index()
        {
            var result = service.GetAllBooks();
            return View(result);
        }

        [HttpPost]
        public ActionResult Index(string searchbook)
        {
            var result = service.GetBooksByAuthor(searchbook);
            return View("Index", result);
        }
        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            var result = service.GetBookById(id);
            return View(result);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                int result = service.AddBook(book);
                if(result >= 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }


        public IActionResult SearchByAuthor(string author)
        {
            IEnumerable<Book> books = service.GetBooksByAuthor(author);
            return View(books);
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            var result = service.GetBookById(id);
            return View(result);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            try
            {
                int result = service.DeleteBook(id);
                if(result >= 1)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
                
            }
            catch
            {
                return View();
            }
        }


    }
}
