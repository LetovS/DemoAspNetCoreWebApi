using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Store.Entities;

namespace Store.Abstract.Context;

public interface IResourceContext
{
    /// <summary>
    /// Поставщики
    /// </summary>
    public DbSet<ProviderRecord> Providers { get; }
    
    /// <summary>
    /// Закзааы
    /// </summary>
    public DbSet<OrderRecord> Orders { get; }
    
    /// <summary>
    /// Товары
    /// </summary>
    public DbSet<OrderItemRecord> OrderItems { get; }
    
    DatabaseFacade Database { get; }
}