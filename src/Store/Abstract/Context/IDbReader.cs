using Store.Abstract.Entity;

namespace Store.Abstract.Context;

public interface IDbReader
{
    /// <summary>
    /// Чтение базы данных.
    /// </summary>
    /// <remarks>.AsNoTracking() - true</remarks>
    IQueryable<TEntity> Read<TEntity>() where TEntity : class, IEntityWithId;
}