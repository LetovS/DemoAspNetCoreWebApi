using Store.Abstract.Context;
using Store.Abstract.Entity;

namespace Repositories.Abstract;

public abstract class WriteRepositoryBase<TEntity> : IDbWriteRepositoryBase<TEntity>
    where TEntity : EntityBase
{
    protected readonly IDbWriter Writer;

    protected WriteRepositoryBase(IDbWriter writer)
    {
        Writer = writer;
    }

    public void Add(TEntity entity) => Writer.Add(entity);

    public void Update(TEntity entity) => Writer.Update(entity);

    public void Delete(TEntity entity) => Writer.Delete(entity);
}