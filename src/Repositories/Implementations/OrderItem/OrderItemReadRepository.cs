using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.OrderItem;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.OrderItem;

/// <summary>
/// Репозиторий чтения товаров
/// </summary>
public class OrderItemReadRepository :
    ReadRepositoryBase<OrderItemRecord>,
    IOrderItemReadRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderItemReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }

    /// <inheritdoc/>
    public async Task<OrderItemRecord?> GetByName(string orderItemName, CancellationToken ct) =>
        await DbReader
               .Read<OrderItemRecord>()
               .Where(x => x.Name!.Equals(orderItemName))
               .FirstOrDefaultAsync(ct);
    
    /// <inheritdoc/>
    public async Task<IReadOnlyList<OrderItemRecord>> GetByOrderId(Guid orderId, CancellationToken ct) =>
        await DbReader
            .Read<OrderItemRecord>()
            .Where(x => x.Id == orderId)
            .ToListAsync(ct);
}