using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Provider;

/// <summary>
/// Репозиторй чтения провайдера
/// </summary>
public sealed class ProviderReadRepository : 
    ReadRepositoryBase<ProviderRecord>,
    IProviderReadRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderReadRepository(IDbReader dbReader) : base(dbReader)
    {
    }
    
    /// <inheritdoc/>
    public async Task<ProviderRecord?> GetByName(string providerName, CancellationToken ct) =>
        await DbReader
            .Read<ProviderRecord>()
            .Where(x => x.ProviderName!.Equals(providerName))
            .FirstOrDefaultAsync(ct);
   
}