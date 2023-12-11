using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Store.Migrations;

public class ResourcesContextFactory : IDesignTimeDbContextFactory<ResourcesContext>
{
    public ResourcesContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ResourcesContext>();

        optionsBuilder
            .UseSqlServer(connectionString: Constants.ConnectionString, opt =>
            {
                opt.MigrationsAssembly(typeof(ResourcesContextFactory).Assembly.FullName);
                opt.MigrationsHistoryTable(Constants.MigrationsHistoryTableName);
            } );
        
        return new ResourcesContext(optionsBuilder.Options);
    }
}