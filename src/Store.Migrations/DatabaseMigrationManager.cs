using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Store.Migrations;

public static class DatabaseMigrationManager
{
    public static async Task MigrateSchema()
    {
        Console.WriteLine("Applying database schema migration...");

        await Migrate<ResourcesContext, ResourcesContextFactory>().ConfigureAwait(false);

        Console.WriteLine("Done");
    }

    private static async Task Migrate<TDbContext, TDbContextFactory>()
        where TDbContext : DbContext
        where TDbContextFactory : IDesignTimeDbContextFactory<TDbContext>, new()
    {
        var dbContextFactory = new TDbContextFactory();
        await using var dbContext = dbContextFactory.CreateDbContext(Array.Empty<string>());

        await dbContext.Database.MigrateAsync().ConfigureAwait(false);
    }
}