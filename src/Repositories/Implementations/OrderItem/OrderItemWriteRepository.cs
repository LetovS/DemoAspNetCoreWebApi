using Repositories.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.OrderItem;

public class OrderItemWriteRepository : WriteRepositoryBase<OrderItemRecord> , IOrderItemWriteRepository
{
    public OrderItemWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}