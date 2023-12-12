using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.Order;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Order;

public class OrderReadRepository : ReadRepositoryBase<OrderRecord> , IOrderReadRepository
{
    public OrderReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }

    public async Task<OrderRecord?> GetByOrderNumber(
        string providerName
        , CancellationToken ct) => 
                            await DbReader
                                .Read<OrderRecord>()
                                .Where(x => x.OrderNumber!.Equals(providerName))
                                .FirstOrDefaultAsync(ct);
}