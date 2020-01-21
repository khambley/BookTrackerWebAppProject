using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookTrackerWebApp.Models;

namespace BookTrackerWebApp.Controllers
{
    public class HomeController : Controller
    {
        private IRepository repository;
        public HomeController(IRepository repo) => repository = repo;

        public IActionResult Index() => View(repository.Books);

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            repository.AddBook(book);
            return RedirectToAction(nameof(Index));
        }
    }
}