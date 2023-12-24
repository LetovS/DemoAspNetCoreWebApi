using Store.Entities;

namespace Repositories.Abstract.OrderItem;

/// <summary>
/// Репозиторий записи пунктов заказа
/// </summary>
public interface IOrderItemWriteRepository : IDbWriteRepositoryBase<OrderItemRecord>
{
    
}