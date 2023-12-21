using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Store.Abstract.Context;
using Store.Abstract.Entity;

namespace Repositories.Abstract;

/// <summary>
/// Базовый репозиторий чтения
/// </summary>
/// <typeparam name="TEntity">Сущность БД</typeparam>
public abstract class ReadRepositoryBase<TEntity> : IDbReadRepositoryBase<TEntity>
where TEntity : EntityBase
{
    /// <summary>
    /// Ридер
    /// </summary>
    protected readonly IDbReader DbReader;

    /// <summary>
    /// ctor.
    /// </summary>
    protected ReadRepositoryBase(IDbReader dbReader)
    {
        DbReader = dbReader;
    }
    
    /// <inheritdoc/>
    public async Task<TEntity?> GetById(Guid id, CancellationToken ct)
    {
        return await DbReader.Read<TEntity>().Where(x => x.Id == id).FirstOrDefaultAsync(ct);
    }

    /// <inheritdoc/>
    [Obsolete("Метод нужно переиграть")]
    public async Task<TEntity?> GetEntityIncluding<TProperty>(
        Guid id,
        Expression<Func<TEntity, TProperty>> navigationProperty
        , CancellationToken ct)
    {
        return await DbReader.Set<TEntity>().Include(navigationProperty).Where(x => x.Id == id).FirstOrDefaultAsync(ct);
    }
    
    /// <inheritdoc/>
    public async Task<bool> IsExistById(Guid id, CancellationToken ct = default)
    {
        var query = DbReader.Read<TEntity>();

        return await query
            .Where(x => x.Id == id)
            .AnyAsync(ct);
    }

    /// <inheritdoc/>
    public async Task<(int total, IReadOnlyList<TEntity> items)> GetAll(int offset = 0, int limit = 100, CancellationToken ct = default)
    {
        var query = DbReader.Read<TEntity>();

        var count = await query.CountAsync(ct);

        if (count > offset)
        {
            return (count,
                await ApplyQueryAdjustments(query)
                    .Skip(offset)
                    .Take(limit)
                    .ToArrayAsync(ct));
        }

        return (count, Array.Empty<TEntity>());
    }
    
    /// <summary>
    /// Настрйоки 
    /// </summary>
    protected virtual IQueryable<TEntity> ApplyQueryAdjustments(IQueryable<TEntity> source) => source;
    
    
    /// <summary>
    ///  Устанавливает навигационные свойства
    /// </summary>
    protected virtual IQueryable<TEntity> IncludeNavigationProperties(IQueryable<TEntity> source) => ApplyQueryAdjustments(source);
}