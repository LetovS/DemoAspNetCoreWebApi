using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Store;

namespace Hosts;

public static class MigrationManager
{
    public static IHost MigrateDatabase(this IHost host)
    {
        using var scope = host.Services.CreateScope();
        using var dbContext = scope.ServiceProvider.GetRequiredService<ResourcesContext>();

        dbContext.Database.Migrate();

        return host;
    }
}