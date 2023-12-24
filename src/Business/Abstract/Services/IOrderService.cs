using Business.Models;
using Business.Models.Order;
using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// 
/// </summary>
public interface IOrderService : IBusinessService<OrderRecord, CreateOrderModel, UpdateOrderModel>
{
    /// <summary>
    /// Получить все заказы по номеру поставщика услуг
    /// </summary>
    Task<IReadOnlyList<OrderRecord>> GetAllByProviderId(Guid providerId, CancellationToken ct = default);

    /// <summary>
    /// Получить заказ по номеру
    /// </summary>
    Task<OrderRecord?> GetByNumber(string number, CancellationToken ct = default);
}