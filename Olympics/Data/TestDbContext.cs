using Microsoft.EntityFrameworkCore;
using Olympics.Data;

public static class TestDbContext
{
    public static ApplicationDbContext GetTestDbContext()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        var context = new ApplicationDbContext(options);
        context.Database.EnsureCreated();
        return context;
    }

    public static void ResetTestDbContext(ApplicationDbContext context)
    {
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();
    }
}