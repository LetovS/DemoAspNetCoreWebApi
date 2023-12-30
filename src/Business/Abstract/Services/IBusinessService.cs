using Business.Abstract.Models;
using Business.Models;
using Store.Abstract.Entity;

namespace Business.Abstract.Services;

/// <summary>
/// Метка бизнес сервиса
/// </summary>
public interface IBusinessService <TEntity, TCreateModel, TUpdateModel>
    where TEntity : class, IEntityWithId
    where TCreateModel : ICreateModel
    where TUpdateModel : class, IUpdateModel
{
    /// <summary>
    /// Получить по ИД
    /// </summary>
    public Task<TEntity?> GetByIdAsync(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить все сущности
    /// </summary>
    public Task<ResourceGetModel<TEntity>> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default);

    /// <summary>
    /// Создать сущность
    /// </summary>
    public Task<Guid> CreateAsync(Guid id, TCreateModel model, CancellationToken ct = default);

    /// <summary>
    /// Обновить модель
    /// </summary>
    public Task<bool> UpdateAsync(Guid id, TUpdateModel model, CancellationToken ct = default);

    /// <summary>
    /// Удалить по ИД
    /// </summary>
    public Task<bool> DeleteAsync(Guid id, CancellationToken ct = default);
}