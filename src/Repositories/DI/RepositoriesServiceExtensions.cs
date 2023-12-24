using Microsoft.Extensions.DependencyInjection;
using Repositories.Abstract;
using Repositories.Abstract.Order;
using Repositories.Abstract.OrderItem;
using Repositories.Abstract.Provider;
using Repositories.Implementations;
using Repositories.Implementations.Order;
using Repositories.Implementations.OrderItem;
using Repositories.Implementations.Provider;

namespace Repositories.DI;

/// <summary>
/// Расширение для сервисов
/// </summary>
public static class RepositoriesServiceExtensions
{
    /// <summary>
    /// Добавление репозиториев и фабрики сущностей
    /// </summary>
    public static void AddRepositoriesAndEntityFactory(this IServiceCollection services)
    {
        services.AddScoped<IProviderReadRepository, ProviderReadRepository>();
        services.AddScoped<IProviderWriteRepository, ProviderWriteRepository>();
        
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        
        services.AddScoped<IOrderItemReadRepository, OrderItemReadRepository>();
        services.AddScoped<IOrderItemWriteRepository, OrderItemWriteRepository>();

        services.AddScoped<IEntityFactory, EntityFactory>();
    }
}