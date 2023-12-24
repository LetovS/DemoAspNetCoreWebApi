using Store.Abstract.Context;
using Store.Abstract.Entity;

namespace Repositories.Abstract;

/// <summary>
/// Базовый репозиторий записи в БД
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public abstract class WriteRepositoryBase<TEntity> : IDbWriteRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    /// <summary>
    /// Читающий БД
    /// </summary>
    protected readonly IDbWriter Writer;

    /// <summary>
    /// ctor.
    /// </summary>
    protected WriteRepositoryBase(IDbWriter writer)
    {
        Writer = writer;
    }

    /// <inheritdoc/>
    public void Add(TEntity entity) => Writer.Add(entity);

    /// <inheritdoc/>
    public void Update(TEntity entity) => Writer.Update(entity);

    /// <inheritdoc/>
    public void Delete(TEntity entity) => Writer.Delete(entity);
}