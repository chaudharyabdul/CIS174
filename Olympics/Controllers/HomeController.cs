using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympics.Data;
using System.Linq;
using System.Threading.Tasks;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var countries = await _context.Countries
            .Include(c => c.Game)
            .Include(c => c.SportType)
            .OrderBy(c => c.Name)
            .ToListAsync();
        return View(countries);
    }

    public async Task<IActionResult> Filter(string game = "ALL", string sportType = "ALL")
    {
        ViewBag.SelectedGame = game;
        ViewBag.SelectedSportType = sportType;

        var countries = _context.Countries
            .Include(c => c.Game)
            .Include(c => c.SportType)
            .AsQueryable();

        if (game != "ALL")
        {
            countries = countries.Where(c => c.Game.Name == game);
        }

        if (sportType != "ALL")
        {
            countries = countries.Where(c => c.SportType.Name == sportType);
        }

        var result = await countries.OrderBy(c => c.Name).ToListAsync();
        return View("Index", result);
    }
}
