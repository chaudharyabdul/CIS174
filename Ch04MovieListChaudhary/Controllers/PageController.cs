using Microsoft.AspNetCore.Mvc;

namespace Ch04MovieListChaudhary.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Default()
        {
            return View();
        }

        [Route("custom-route-page")]
        public IActionResult CustomRoutePage()
        {
            return View();
        }

        [Route("attribute-route-page")]
        public IActionResult AttributeRoutePage()
        {
            return View();
        }
    }
}
