using Microsoft.EntityFrameworkCore;
using Olympics.Models;

namespace Olympics.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<SportType> SportTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>().HasData(
                new Game { Id = 1, Name = "Summer Olympics" },
                new Game { Id = 2, Name = "Winter Olympics" },
                new Game { Id = 3, Name = "Paralympics" },
                new Game { Id = 4, Name = "Youth Olympic Games" }
            );

            modelBuilder.Entity<SportType>().HasData(
                new SportType { Id = 1, Name = "Indoor" },
                new SportType { Id = 2, Name = "Outdoor" }
            );

            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Canada", CountryCode = "CA", GameId = 2, SportTypeId = 1 },
                new Country { Id = 2, Name = "Sweden", CountryCode = "SE", GameId = 2, SportTypeId = 1 },
                new Country { Id = 3, Name = "Great Britain", CountryCode = "GB", GameId = 2, SportTypeId = 1 },
                new Country { Id = 4, Name = "Jamaica", CountryCode = "JM", GameId = 2, SportTypeId = 2 },
                new Country { Id = 5, Name = "Italy", CountryCode = "IT", GameId = 2, SportTypeId = 2 },
                new Country { Id = 6, Name = "Japan", CountryCode = "JP", GameId = 2, SportTypeId = 2 },
                new Country { Id = 7, Name = "Germany", CountryCode = "DE", GameId = 1, SportTypeId = 1 },
                new Country { Id = 8, Name = "China", CountryCode = "CN", GameId = 1, SportTypeId = 1 },
                new Country { Id = 9, Name = "Mexico", CountryCode = "MX", GameId = 1, SportTypeId = 1 },
                new Country { Id = 10, Name = "Brazil", CountryCode = "BR", GameId = 1, SportTypeId = 2 },
                new Country { Id = 11, Name = "Netherlands", CountryCode = "NL", GameId = 1, SportTypeId = 2 },
                new Country { Id = 12, Name = "USA", CountryCode = "US", GameId = 1, SportTypeId = 2 },
                new Country { Id = 13, Name = "Thailand", CountryCode = "TH", GameId = 3, SportTypeId = 1 },
                new Country { Id = 14, Name = "Uruguay", CountryCode = "UY", GameId = 3, SportTypeId = 1 },
                new Country { Id = 15, Name = "Ukraine", CountryCode = "UA", GameId = 3, SportTypeId = 1 },
                new Country { Id = 16, Name = "Austria", CountryCode = "AT", GameId = 3, SportTypeId = 2 },
                new Country { Id = 17, Name = "Pakistan", CountryCode = "PK", GameId = 3, SportTypeId = 2 },
                new Country { Id = 18, Name = "Zimbabwe", CountryCode = "ZW", GameId = 3, SportTypeId = 2 },
                new Country { Id = 19, Name = "France", CountryCode = "FR", GameId = 4, SportTypeId = 1 },
                new Country { Id = 20, Name = "Cyprus", CountryCode = "CY", GameId = 4, SportTypeId = 1 },
                new Country { Id = 21, Name = "Russia", CountryCode = "RU", GameId = 4, SportTypeId = 1 },
                new Country { Id = 22, Name = "Finland", CountryCode = "FI", GameId = 4, SportTypeId = 2 },
                new Country { Id = 23, Name = "Slovakia", CountryCode = "SK", GameId = 4, SportTypeId = 2 },
                new Country { Id = 24, Name = "Portugal", CountryCode = "PT", GameId = 4, SportTypeId = 2 }
            );
        }
    }
}