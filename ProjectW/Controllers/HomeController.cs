using Microsoft.AspNetCore.Mvc;
using ProjectW.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ProjectW.Data;

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

        public async Task<IActionResult> Privacy(string searchString)
        {
            if (_context.Book == null)
            {
                return Problem("Not book");
            }

            var books = from b in _context.Book select b;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(s => s.Title!.Contains(searchString));
            }

            return View(await books.ToListAsync());
        }

        //Trang chi tiết sản phẩm
        public async Task<IActionResult> Detail(int id)
        {
            var book = await _context.Book.Include(b => b.Category)
                            .FirstOrDefaultAsync(m => m.BookId == id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}