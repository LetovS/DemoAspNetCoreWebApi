using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Store.Abstract.Context;
using Store.Abstract.Entity;

namespace Repositories.Abstract;

public abstract class ReadRepositoryBase<TEntity> : IDbReadRepositoryBase<TEntity>
where TEntity : EntityBase
{
    protected readonly IDbReader DbReader;

    protected ReadRepositoryBase(IDbReader dbReader)
    {
        DbReader = dbReader;
    }
    
    public async Task<TEntity?> GetById(Guid id, CancellationToken ct)
    {
        return await DbReader.Read<TEntity>().Where(x => x.Id == id).FirstOrDefaultAsync(ct);
    }

    public async Task<TEntity?> GetEntitysIncluding<TProperty>(
        Guid id,
        Expression<Func<TEntity, TProperty>> navigationProperty
        , CancellationToken ct)
    {
        return await DbReader.Set<TEntity>().Include(navigationProperty).Where(x => x.Id == id).FirstOrDefaultAsync(ct);
    }


    public async Task<bool> IsExistById(Guid id, CancellationToken ct = default)
    {
        var query = DbReader.Read<TEntity>();

        return await query
            .Where(x => x.Id == id)
            .AnyAsync(ct);
    }

    public async Task<(int total, IReadOnlyCollection<TEntity> items)> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default)
    {
        var query = DbReader.Read<TEntity>();

        var count = await query.CountAsync(ct);

        if (count > offset)
        {
            return (count,
                await AdjustQuery(query)
                    .Skip(offset)
                    .Take(limit)
                    .ToArrayAsync(ct));
        }

        return (count, Array.Empty<TEntity>());
    }
    
    protected virtual IQueryable<TEntity> AdjustQuery(IQueryable<TEntity> source) => source;

    protected virtual IQueryable<TEntity> AdjustQueryIncludingAll(IQueryable<TEntity> source) => AdjustQuery(source);
}