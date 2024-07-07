using Microsoft.AspNetCore.Mvc;
using Olympics.Services;

public class FavoritesController : Controller
{
    private readonly FavoritesService _favoritesService;

    public FavoritesController(FavoritesService favoritesService)
    {
        _favoritesService = favoritesService;
    }

    public IActionResult Index()
    {
        var favorites = _favoritesService.GetFavorites();
        return View(favorites);
    }

    public IActionResult ClearFavorites()
    {
        _favoritesService.ClearFavorites();
        return RedirectToAction(nameof(Index));
    }
}