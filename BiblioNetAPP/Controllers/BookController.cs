
using BiblioNetAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            return !ModelState.IsValid ? 
                View(book) : 
                View();
        }
    }
}
