using Store.Abstract.Entity;

namespace Store.Abstract.Context;

public interface IDbReader
{
    
    IQueryable<TEntity> Read<TEntity>() where TEntity : class, IEntityWithId;
}