using Store.Abstract.Entity;

namespace Business.Abstract;

/// <summary>
/// Базовая валидация бизнес процесса
/// </summary>
public abstract class ValidatorBase<TEntity> : IBusinessValidator<TEntity>
    where TEntity : IEntityWithId
{
    /// <inheritdoc/>
    public virtual async Task ValidateSave(TEntity entity, CancellationToken ct) => await Task.CompletedTask;

    /// <inheritdoc/>
    public virtual async Task ValidateDelete(Guid entityId, CancellationToken ct) => await Task.CompletedTask;
}