using Store.Entities;

namespace Repositories.Abstract.Order;

public interface IOrderReadRepository: IDbReadRepositoryBase<OrderRecord>
{
    /// <summary>
    /// Получить заказ по номеру
    /// </summary>
    Task<OrderRecord?> GetByOrderNumber(string orderNumber, CancellationToken ct = default);
}