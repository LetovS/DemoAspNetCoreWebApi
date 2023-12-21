using Store.Entities;

namespace Repositories.Abstract.Provider;

/// <summary>
/// Репозиторий чтения поставщика услуг
/// </summary>
public interface IProviderReadRepository : IDbReadRepositoryBase<ProviderRecord>
{
    /// <summary>
    /// Получить поставщика услуг по названию
    /// </summary>
    Task<ProviderRecord?> GetByName(string providerName, CancellationToken ct = default);
}