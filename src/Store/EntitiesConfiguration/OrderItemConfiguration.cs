using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using Store.EntitiesConfiguration.Extensions;

namespace Store.EntitiesConfiguration;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItemRecord>
{
    public void Configure(EntityTypeBuilder<OrderItemRecord> builder)
    {
        builder.ToTable("OrderItems");
        
        builder.ConfigureBaseEntity();
        
        builder.Property(p => p.Name).HasMaxLength(255).IsRequired();

        builder.Property(p => p.Unit).HasMaxLength(255).IsRequired();

        builder.Property(p => p.Quantity).HasColumnType("decimal").HasPrecision(18,2).IsRequired();
    }
}