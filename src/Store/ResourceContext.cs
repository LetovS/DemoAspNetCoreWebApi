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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

        InitializationData(modelBuilder);
    }

    private static void InitializationData(ModelBuilder modelBuilder)
    {
        var providers = Enumerable
            .Range(1, 10)
            .Select(id => new ProviderRecord(Guid.NewGuid(), $"Provider name {id}")).ToList();

        var providersId = providers.Select(x => x.Id).ToList();
        
        modelBuilder.Entity<ProviderRecord>()
            .HasData(providers);

        
        
        var rnd = new Random();
        var orders = Enumerable
            .Range(1, 100)
            .Select(id => new OrderRecord(Guid.NewGuid(),
                    $"Order number {id}",
                    DateTime.Now)
            { ProviderId = providersId[rnd.Next(1, 10)] }
            ).ToList();
        
        // Начальные данные для OrderRecord
        modelBuilder.Entity<OrderRecord>()
            .HasData(orders);
        
        var ordersId = orders.Select(x => x.Id).ToList();
        
        modelBuilder.Entity<OrderItemRecord>()
            .HasData(
                Enumerable
                    .Range(1,2500)
                    .Select(id => new OrderItemRecord(Guid.NewGuid(),
                            $"Order name {id}",
                            GetRandomPrice(),
                            "усл. ед")
                    { OrderId = ordersId[rnd.Next(1, 10)] }
                    )
            );

        // Получает цену в диапазоне 100..1000 
        decimal GetRandomPrice() => (decimal)(rnd.Next(100, 1000) * rnd.NextDouble());
    }
    
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