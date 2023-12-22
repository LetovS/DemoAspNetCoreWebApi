using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using Store.EntitiesConfiguration.Extensions;

namespace Store.EntitiesConfiguration;

/// <summary>
/// Конфигурирование заказа
/// </summary>
public class OrderConfiguration : IEntityTypeConfiguration<OrderRecord>
{
    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<OrderRecord> builder)
    {
        builder.ToTable("Orders");
        
        builder.ConfigureBaseEntity();
        
        builder.Property(o => o.OrderNumber).HasMaxLength(255).IsRequired();

        builder.Property(o => o.OrderDate).HasColumnType("date").IsRequired();

        builder.HasIndex(o => new { o.OrderNumber/*, o.ProviderId*/ }).HasDatabaseName("UQ_Orders_Number").IsUnique();
    }
}