using Store.Abstract.Entity;

namespace Repositories.Abstract;

public interface IDbReadRepositoryBase<TEntity> : IDbRepository
where TEntity : IEntity
{
    IQueryable Read<TEntity>();
}