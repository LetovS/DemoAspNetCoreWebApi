using Microsoft.EntityFrameworkCore;
using Store.Abstract.Context;
using Store.Entities;

namespace Store;

public class ResourceContext : 
    DbContext,
    IResourceContext, 
    IDbWriter,
    IDbReader,
    IUnitOfWork
{

    public ResourceContext(DbContextOptions<ResourceContext> options) : base(options) {}
    
    public DbSet<ProviderRecord> Providers => Set<ProviderRecord>();
    
    public DbSet<OrderRecord> Orders => Set<OrderRecord>();
    
    public DbSet<OrderItemRecord> OrderItems => Set<OrderItemRecord>();

    void IDbWriter.Add<TEntity>(TEntity entity) => base.Entry(entity).State = EntityState.Added;

    void IDbWriter.Update<TEntity>(TEntity entity) => base.Entry(entity).State = EntityState.Modified;

    void IDbWriter.Delete<TEntity>(TEntity entity) => base.Entry(entity).State = EntityState.Deleted;

    IQueryable<TEntity> IDbReader.Read<TEntity>() => base.Set<TEntity>()
        .AsNoTracking()
        .AsQueryable();

    async Task<int> IUnitOfWork.SaveChangesAsync(CancellationToken ct)
    {
        var count = await base.SaveChangesAsync(ct);

        foreach (var entry in base.ChangeTracker.Entries().ToArray())
        {
            entry.State = EntityState.Detached;
        }

        return count;
    } 
}