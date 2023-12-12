using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Provider;

public class ProviderReadRepository : ReadRepositoryBase<ProviderRecord> , IProviderReadRepository
{
    public ProviderReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }

    public async Task<ProviderRecord?> GetByName(
        string providerName
        , CancellationToken ct) => 
                                await DbReader
                                    .Read<ProviderRecord>()
                                    .Where(x => x.ProviderName!.Equals(providerName))
                                    .FirstOrDefaultAsync(ct);
   
}