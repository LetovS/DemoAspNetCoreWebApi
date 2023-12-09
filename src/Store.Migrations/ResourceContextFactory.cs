using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Store.Migrations;

public class ResourceContextFactory : IDesignTimeDbContextFactory<ResourceContext>
{
    public ResourceContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ResourceContext>();

        optionsBuilder
            .UseSqlServer(connectionString: Constants.ConnectionString, opt =>
            {
                opt.MigrationsAssembly(typeof(ResourceContextFactory).Assembly.FullName);
                opt.MigrationsHistoryTable(Constants.MigrationsHistoryTableName);
            } );
        
        return new ResourceContext(optionsBuilder.Options);
    }
}