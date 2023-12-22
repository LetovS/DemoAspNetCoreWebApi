using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.DI;

namespace Web.Hosts;

internal static class Startup
{
    /// <inheritdoc/>
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var databaseOptions = new DatabaseOptions();
        
        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        
        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();
        return services;
    }   
}

