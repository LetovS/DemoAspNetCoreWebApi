using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Store.Migrations;

/// <summary>
/// Фабрика контекста <see cref="ResourcesContext"/>
/// </summary>
public class ResourcesContextFactory : IDesignTimeDbContextFactory<ResourcesContext>
{
    /// <inheritdoc/>
    public ResourcesContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ResourcesContext>();

        optionsBuilder
            .UseSqlServer(connectionString: Constants.ConnectionString, opt =>
            {
                opt.MigrationsAssembly(Constants.MigrationsAssemblyName);
                opt.MigrationsHistoryTable(Constants.MigrationsHistoryTableName);
            } );
        
        return new ResourcesContext(optionsBuilder.Options);
    }
}