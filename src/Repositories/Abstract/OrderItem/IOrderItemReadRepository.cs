using Store.Entities;

namespace Repositories.Abstract.OrderItem;

/// <summary>
/// Репозиторий чтения пунктов заказа
/// </summary>
public interface IOrderItemReadRepository : IDbReadRepositoryBase<OrderItemRecord>
{
    /// <summary>
    /// Получить товар по названию
    /// </summary>
    Task<OrderItemRecord?> GetByName(string orderItemName, CancellationToken ct = default);

    /// <summary>
    /// Получить товары по ИД заказа
    /// </summary>
    Task<IReadOnlyList<OrderItemRecord>> GetByOrderId(Guid orderId, CancellationToken ct);
}