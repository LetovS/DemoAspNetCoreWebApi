using Business.Models;
using Business.Models.Provider;
using Store.Entities;

namespace Business.Abstract.Services;

/// <summary>
/// Сервис провайдеров
/// </summary>
public interface IProviderService : IBusinessService
{
    /// <summary>
    /// Получить по ИД
    /// </summary>
    public Task<ProviderRecord?> GetByIdAsync(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить все сущности
    /// </summary>
    public Task<ResourceGetModel<ProviderRecord>> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Создать сущность
    /// </summary>
    public Task<Guid> CreateAsync(Guid id, CreateProviderModel model, CancellationToken ct = default);

    /// <summary>
    /// Обновить модель
    /// </summary>
    public Task<bool> UpdateAsync(Guid id, UpdateProviderModel model, CancellationToken ct = default);

    /// <summary>
    /// Удалить по ИД
    /// </summary>
    public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
    
    /// <summary>
    /// Получить поставщика услуг по названию
    /// </summary>
    Task<ProviderRecord?> GetByName(string name, CancellationToken ct = default);
}