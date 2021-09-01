using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{

    //localhost/livre/
    [Route("livre")]
    public class LivreController : Controller
    {
        private BooksService _booksService;
     public LivreController(BooksService bookService)
        {
            _booksService = bookService;
        }
        public IActionResult Index()
        {
            ViewBag.books = _booksService.getBooks();
            return View();
        }


        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {

            Livre livre = _booksService.getBooks().Find((liv) =>liv.Id==id);
            ViewBag.id = id;
            ViewBag.livre = livre;
            return View();
        }

        [HttpPost()]
        public IActionResult AddBook(Livre livre)
        {

            _booksService.AddBook(livre);

            return RedirectToAction("Index");
        }
    }
}
