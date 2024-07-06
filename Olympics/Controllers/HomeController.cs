using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Olympics.Data;
using Olympics.Models;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var viewModel = new OlympicsFilterViewModel
        {
            Game = "ALL",
            SportType = "ALL",
            Countries = await _context.Countries
                .Include(c => c.Game)
                .Include(c => c.SportType)
                .OrderBy(c => c.Name)
                .ToListAsync()
        };
        return View(viewModel);
    }

    public async Task<IActionResult> Filter(string game = "ALL", string sportType = "ALL")
    {
        var countriesQuery = _context.Countries
            .Include(c => c.Game)
            .Include(c => c.SportType)
            .AsQueryable();

        if (game != "ALL")
        {
            countriesQuery = countriesQuery.Where(c => c.Game.Name == game);
        }

        if (sportType != "ALL")
        {
            countriesQuery = countriesQuery.Where(c => c.SportType.Name == sportType);
        }

        var viewModel = new OlympicsFilterViewModel
        {
            Game = game,
            SportType = sportType,
            Countries = await countriesQuery.OrderBy(c => c.Name).ToListAsync()
        };

        return View("Index", viewModel);
    }
}