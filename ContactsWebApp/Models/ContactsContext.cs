using Microsoft.EntityFrameworkCore;

namespace ContactsWebApp.Models
{
    public class ContactsContext : DbContext
    {
        public ContactsContext(DbContextOptions<ContactsContext> options) : base(options) 
        { }
        public DbSet<Contact> Contacts { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    Id = 1,
                    Name = "Nat Ferguson",
                    PhoneNumber = "5151239876",
                    Address = "101 Main St, West Des Moines, IA 50266",
                    Note = "Best Friend"
                },
                new Contact
                {
                    Id = 2,
                    Name = "Johnny Cash",
                    PhoneNumber = "5159871234",
                    Address = "1000 Ghost Rider St, West Des Moines, IA 50266",
                    Note = "Greatest country singer"
                },
                new Contact
                {
                    Id = 3,
                    Name = "Clark Kent",
                    PhoneNumber = "5151020304",
                    Address = "2525 Broadway, Metropolis, NY 10025",
                    Note = "Don't need any introduction"
                }
            );
        }
    }
}
