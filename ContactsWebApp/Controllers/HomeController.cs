using ContactsWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactsWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ContactsContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ContactsContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.OrderBy(m => m.Name).ToList(); // Use _context
            return View(contacts);
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
