using Store.Entities;

namespace Repositories.Abstract.Provider;

public interface IProviderReadRepository : IDbReadRepositoryBase<ProviderRecord>
{
    /// <summary>
    /// Получить поставщика услуг по названию
    /// </summary>
    Task<ProviderRecord?> GetByName(string providerName, CancellationToken ct = default);
}