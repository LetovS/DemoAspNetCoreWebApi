using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.OrderItem;

public class OrderItemReadRepository : ReadRepositoryBase<OrderItemRecord> , IOrderItemReadRepository
{
    public OrderItemReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }

    public async Task<OrderItemRecord?> GetByName(
            string orderItemName,
            CancellationToken ct)
                => await DbReader
                        .Read<OrderItemRecord>()
                        .Where(x => x.Name!.Equals(orderItemName))
                        .FirstOrDefaultAsync(ct);
    
}