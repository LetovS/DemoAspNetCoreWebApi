using Repositories.Abstract;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Provider;

public class ProviderWriteRepository : WriteRepositoryBase<ProviderRecord> , IProviderWriteRepository
{
    public ProviderWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}