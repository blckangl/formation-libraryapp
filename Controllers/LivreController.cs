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
        private LibraryContext _dbContext;
     public LivreController(LibraryContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            ViewBag.books = _dbContext.books.ToList<Livre>();
            return View();

        }


        [HttpGet("add")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("add")]
        public IActionResult AddBook(Livre livre)
        {
            if (!ModelState.IsValid)
            {
                return View("Create");
            }
            _dbContext.books.Add(livre);

            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet("{id}")]
        public IActionResult Details(int id)
        {
            Livre livre = _dbContext.books.Find(id);
            ViewBag.id = id;
            ViewBag.livre = livre;
            return View();
        }

      


        //[HttpDelete("{livreId}")]
        //public IActionResult DeleteBook(int livreId)
        //{
        //    _booksService.RemoveBook(livreId);

        //    return Ok();
        //}
    }
}
