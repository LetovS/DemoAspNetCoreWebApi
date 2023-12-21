using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// Сервис провайдеров
/// </summary>
public interface IProviderService : IBusinessService
{
    /// <summary>
    /// Получить поставщика услуг по названию
    /// </summary>
    Task<ProviderRecord?> GetByName(string name, CancellationToken ct = default);
}