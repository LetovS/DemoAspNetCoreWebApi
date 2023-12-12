using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Abstract.Context;
using Store.ConfigurationOptions;

namespace Store.DI;

public static class StoreServiceCollectionExtensions
{
    /// <summary>
    /// Внедрям зависимости
    /// </summary>
    /// <remarks>Добавляются: ResourcesContext, IResourcesContext, IDbWriter, IDbReader, IDbUnitOfWork</remarks>
    public static void AddStoreDependencies(this IServiceCollection services, DatabaseOptions options)
    {
        services.AddDbContext<ResourcesContext>(opt => opt.UseSqlServer(options.ConnectionString
            , opts => {
                opts.MigrationsHistoryTable(options.MigrationsHistoryTableName);
                opts.MigrationsAssembly(options.MigrationsAssemblyName);
            }));
        
        // Добавляем контекст таким образом, чтобы при вызове был один и тот же экземляр контекста
        services.AddScoped<IResourcesContext>(provider => provider.GetRequiredService<ResourcesContext>());
        services.AddScoped<IDbWriter>(provider => provider.GetRequiredService<ResourcesContext>());
        services.AddScoped<IDbReader>(provider => provider.GetRequiredService<ResourcesContext>());
        services.AddScoped<IDbUnitOfWork>(provider => provider.GetRequiredService<ResourcesContext>());
    }
}