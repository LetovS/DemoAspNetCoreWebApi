using Store.Entities;

namespace Repositories.Abstract.Provider;

/// <summary>
/// Репозиторий записи поставщика услуг
/// </summary>
public interface IProviderWriteRepository : IDbWriteRepositoryBase<ProviderRecord>
{
    
}