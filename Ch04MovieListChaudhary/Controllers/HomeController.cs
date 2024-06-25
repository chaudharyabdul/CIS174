using Ch04MovieListChaudhary.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Ch04MovieListChaudhary.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx)
        {
            context = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        public IActionResult Index()
        {
            var movies = context.Movies.Include(m => m.Genre).OrderBy(m => m.Name).ToList();
            return View(movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
