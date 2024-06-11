using FirstResponsiveWebAppChaudhary.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstResponsiveWebAppChaudhary.Controllers
{
    public class HomeController : Controller
    {
        private const int CurrentYear = 2024; // Global constant

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Hello, {user.Name}! On December 31st, {CurrentYear}, you will be {user.AgeThisYear(CurrentYear)} years old.";

                if (user.BirthDate.HasValue)
                {
                    ViewBag.ExtraMessage = $"Today, you are {user.AgeToday()} years old."; // If DOB provided
                }
            }
            return View(user);
        }
    }
}
