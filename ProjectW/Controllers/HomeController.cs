using Microsoft.AspNetCore.Mvc;
using ProjectW.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ProjectW.Data;
//using ProjectW.Models;

namespace ProjectW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectWContext _context;

        public HomeController(ILogger<HomeController> logger, ProjectWContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            var books = _context.Book.ToList();
            return View(books);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}