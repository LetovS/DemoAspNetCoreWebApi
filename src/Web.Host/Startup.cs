using Business.DI;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories.DI;
using Store.ConfigurationOptions;
using Store.DI;

namespace Web.Hosts;

/// <summary>
/// Конфигурация хоста <see cref="Program"/>
/// </summary>
public static class Startup
{
    /// <summary>
    /// Конфигуратор сервисов
    /// </summary>
    public static IServiceCollection ConfigureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var databaseOptions = new DatabaseOptions();
        
        configuration.GetSection(nameof(DatabaseOptions)).Bind(databaseOptions);
        
        services.AddStoreDependencies(databaseOptions);

        services.AddRepositoriesAndEntityFactory();

        services.AddBusinessServices();
        
        return services;
    }   
}

