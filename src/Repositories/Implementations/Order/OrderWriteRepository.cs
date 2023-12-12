using Repositories.Abstract;
using Repositories.Abstract.Order;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Order;

public class OrderWriteRepository : WriteRepositoryBase<OrderRecord> , IOrderWriteRepository
{
    public OrderWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}