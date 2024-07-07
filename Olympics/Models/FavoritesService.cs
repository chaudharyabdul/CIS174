using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Olympics.Models;
using System.Collections.Generic;

namespace Olympics.Services
{
    public class FavoritesService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public FavoritesService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        public List<Country> GetFavorites()
        {
            var favorites = Session.GetString("Favorites");
            return favorites == null ? new List<Country>() : JsonConvert.DeserializeObject<List<Country>>(favorites);
        }

        public void AddToFavorites(Country country)
        {
            var favorites = GetFavorites();
            if (!favorites.Exists(c => c.Id == country.Id))
            {
                favorites.Add(country);
                Session.SetString("Favorites", JsonConvert.SerializeObject(favorites));
            }
        }

        public void ClearFavorites()
        {
            Session.Remove("Favorites");
        }
    }
}
