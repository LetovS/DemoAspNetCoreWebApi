using Business.Abstract;
using Business.Abstract.Services;
using Business.Implementations.HasNoChange;
using Business.Implementations.Services;
using Business.Implementations.Validators;
using Business.Models.Order;
using Business.Models.OrderItem;
using Business.Models.Provider;
using Microsoft.Extensions.DependencyInjection;
using Store.Entities;

namespace Business.DI;

/// <summary>
/// Расширение Business для <see cref="IServiceCollection" />
/// </summary>
public static class BusinessServiceCollectionExtension
{
    /// <summary>
    /// Добавление бизнес сервисов в DI/>
    /// </summary>
    public static void AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IBusinessValidator<ProviderRecord>, ProviderValidator>();
        services.AddScoped<IBusinessValidator<OrderRecord>, OrderValidator>();
        services.AddScoped<IBusinessValidator<OrderItemRecord>, OrderItemValidator>();
        
        services.AddScoped<IChangeDetector<ProviderRecord, UpdateProviderModel>, ProviderChangeDetector>();
        services.AddScoped<IChangeDetector<OrderRecord, UpdateOrderModel>, OrderChangeDetector>();
        services.AddScoped<IChangeDetector<OrderItemRecord, UpdateOrderItemModel>, OrderItemChangeDetector>();
        
        
        services.AddScoped<IProviderService, ProviderService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<IOrderItemService, OrderItemService>();
    }
}