using Store.Abstract.Entity;

namespace Repositories.Abstract;

public interface IDbWriteRepositoryBase<in TEntity> : IDbRepository
where TEntity : class, IEntity
{
    /// <summary>
    /// Добавить сущность
    /// </summary>
    void Add(TEntity entity);

    /// <summary>
    /// Обновить объект
    /// </summary>
    void Update(TEntity entity);

    /// <summary>
    /// Удалить объект
    /// </summary>
    void Delete(TEntity entity);
}