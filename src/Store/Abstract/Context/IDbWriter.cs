using Store.Abstract.Entity;

namespace Store.Abstract.Context;

/// <summary>
/// Врайтер
/// </summary>
public interface IDbWriter
{
    /// <summary>
    /// Добавление объекта <see cref="IEntityWithId"/> в БД
    /// </summary>
    void Add<TEntity>(TEntity entity) where TEntity : class, IEntityWithId;

    /// <summary>
    /// Обновление объекта <see cref="IEntityWithId"/> в БД
    /// </summary>
    void Update<TEntity>(TEntity entity) where TEntity : class, IEntityWithId;

    /// <summary>
    /// Удаление объекта <see cref="IEntityWithId"/> из БД
    /// </summary>
    void Delete<TEntity>(TEntity entity) where TEntity : class, IEntityWithId;
}