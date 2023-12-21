using System.Linq.Expressions;
using Store.Abstract.Entity;

namespace Repositories.Abstract;

/// <summary>
/// Интерфейс для базового репозитория чтения
/// </summary>
public interface IDbReadRepositoryBase<TEntity> : IDbRepository
where TEntity : IEntity
{
    /// <summary>
    /// Получить сущность по ИД
    /// </summary>
    Task<TEntity?> GetById(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить сущность по ИД с навигационным свойством
    /// </summary>
    Task<TEntity?> GetEntityIncluding<TProperty>(Guid id, Expression<Func<TEntity, TProperty>> navigationProperty, CancellationToken ct = default);

    /// <summary>
    /// Проверить сущность на существование
    /// </summary>
    Task<bool> IsExistById(Guid id, CancellationToken ct = default);

    /// <summary>
    /// Получить все записи
    /// </summary>
    /// <param name="offset">Количество элементов которое нужно пропустить</param>
    /// <param name="limit">Количество элементов которое нужно взять</param>
    /// <param name="ct">Токен отмены</param>
    Task<(int total, IReadOnlyList<TEntity> items)> GetAll(
        int offset = 0,
        int limit = 100,
        CancellationToken ct = default);
}