using Ch04MovieListChaudhary.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Ch04MovieListChaudhary.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }

        public HomeController(MovieContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var movies = context.Movies.OrderBy(m => m.Name).ToList();
            return View(movies);
        }

        private readonly ILogger<HomeController> _logger;

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
