using Store.Abstract.Entity;

namespace Business.Abstract;

public interface IBusinessValidator<in TEntity>
    where TEntity : IEntity
{
    /// <summary>
    /// Валидация сущности перед сохранением
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="ct">Токен отмены</param>
    Task ValidateSave(TEntity entity, CancellationToken ct = default);

    /// <summary>
    /// Валидация сущности перед удалением
    /// </summary>
    /// <param name="entityId">ИД сущности</param>
    /// <param name="ct">Токен отмены</param>
    Task ValidateDelete(Guid entityId, CancellationToken ct = default);
}