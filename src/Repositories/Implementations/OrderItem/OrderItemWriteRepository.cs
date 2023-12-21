using Repositories.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.OrderItem;

/// <summary>
/// Репозиторий записи пунктов заказа
/// </summary>
public class OrderItemWriteRepository :
    WriteRepositoryBase<OrderItemRecord>,
    IOrderItemWriteRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}