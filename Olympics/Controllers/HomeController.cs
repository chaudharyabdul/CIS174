using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Olympics.Data;
using Olympics.Models;
using Olympics.Services;
using System.Linq;
using System.Threading.Tasks;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly FavoritesService _favoritesService;

    public HomeController(ApplicationDbContext context, FavoritesService favoritesService)
    {
        _context = context;
        _favoritesService = favoritesService;
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

    public async Task<IActionResult> Details(int id)
    {
        var country = await _context.Countries
            .Include(c => c.Game)
            .Include(c => c.SportType)
            .FirstOrDefaultAsync(c => c.Id == id);

        if (country == null)
        {
            return NotFound();
        }

        return View(country);
    }

    public IActionResult AddToFavorites(int id)
    {
        var country = _context.Countries.Find(id);
        if (country != null)
        {
            _favoritesService.AddToFavorites(country);
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult ViewFavorites()
    {
        var favorites = _favoritesService.GetFavorites();
        return View(favorites);
    }
}