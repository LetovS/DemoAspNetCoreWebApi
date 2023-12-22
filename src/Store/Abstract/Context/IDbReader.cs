using Store.Abstract.Entity;

namespace Store.Abstract.Context;

/// <summary>
/// Ридер
/// </summary>
public interface IDbReader
{
    /// <summary>
    /// Чтение базы данных.
    /// </summary>
    /// <remarks>.AsNoTracking() - true</remarks>
    IQueryable<TEntity> Read<TEntity>() where TEntity : class, IEntityWithId;

    /// <summary>
    /// 
    /// </summary>
    public IQueryable<TEntity> Set<TEntity> () where TEntity : class, IEntityWithId;
}