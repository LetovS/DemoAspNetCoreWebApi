using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Store.Entities;

namespace Store.Abstract.Context;

/// <summary>
/// Определение контекста БД
/// </summary>
public interface IResourcesContext
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
    
    /// <summary>
    /// Фасад
    /// </summary>
    DatabaseFacade Database { get; }
}