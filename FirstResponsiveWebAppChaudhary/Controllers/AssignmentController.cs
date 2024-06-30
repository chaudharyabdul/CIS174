using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppChaudhary.Models;

namespace FirstResponsiveWebAppChaudhary.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index(int accessLevel)
        {
            // Logic to handle accessLevel and prepare data for the view
            // Example data for demonstration:
            var students = new List<Student>
            {
                new Student { FirstName = "Daniel", LastName = "Kanyavimonh", Grade = 90 },
                new Student { FirstName = "Mike", LastName = "Mack", Grade = 92 },
                new Student { FirstName = "Patrick", LastName = "Matshumba", Grade = 89 }
            };

            var viewModel = new AssignmentViewModel
            {
                Students = students,
                AccessLevel = accessLevel
            };

            // Pass the viewModel to the view
            return View(viewModel);
        }
    }
}