using Repositories.Abstract;
using Repositories.Abstract.Provider;
using Store.Abstract.Context;
using Store.Entities;

namespace Repositories.Implementations.Provider;

/// <summary>
/// Репозиторй запиви провайдеров
/// </summary>
public class ProviderWriteRepository :
    WriteRepositoryBase<ProviderRecord>,
    IProviderWriteRepository
{
    /// <summary>
    /// ctor.
    /// </summary>
    public ProviderWriteRepository(IDbWriter writer) : base(writer)
    {
    }
}