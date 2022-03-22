
using BiblioNetAPP.Models;
using BiblioNetAPP.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        private readonly IReporitorieBooks repositorieBooks;

        public BookController(IReporitorieBooks repositorieBooks)
        {
            this.repositorieBooks = repositorieBooks;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            
            repositorieBooks.Create(book);
            return View();
        }
    }
}
