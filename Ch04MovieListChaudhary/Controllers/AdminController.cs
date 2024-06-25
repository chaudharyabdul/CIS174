using Microsoft.AspNetCore.Mvc;

namespace Ch04MovieListChaudhary.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
