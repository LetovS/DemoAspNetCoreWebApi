using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.Order;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Order;

/// <summary>
/// Репозиторий чтения заказов
/// </summary>
public class OrderReadRepository :
    ReadRepositoryBase<OrderRecord>,
    IOrderReadRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public OrderReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }

    /// <inheritdoc/>
    public async Task<OrderRecord?> GetByOrderNumber([NotNull] string providerName, CancellationToken ct) => 
        await DbReader
            .Read<OrderRecord>()
            .Where(x => x.OrderNumber!.Equals(providerName))
            .FirstOrDefaultAsync(ct);

    /// <inheritdoc/>
    public async Task<IReadOnlyList<OrderRecord>> GetByProviderId(Guid providerId, CancellationToken ct) =>
        await DbReader
            .Read<OrderRecord>()
            .Where(x => x.ProviderId == providerId)
            .ToListAsync(ct);
}