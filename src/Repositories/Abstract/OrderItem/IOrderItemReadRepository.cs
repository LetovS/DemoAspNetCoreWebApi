using Store.Entities;

namespace Repositories.Abstract.OrderItem;

public interface IOrderItemReadRepository : IDbReadRepositoryBase<OrderItemRecord>
{
    /// <summary>
    /// Получить товар по названию
    /// </summary>
    Task<OrderItemRecord?> GetByName(string orderItemName, CancellationToken ct = default);
}