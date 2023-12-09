using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using Store.EntitiesConfiguration.Extensions;

namespace Store.EntitiesConfiguration;

public class OrderConfiguration : IEntityTypeConfiguration<OrderRecord>
{
    public void Configure(EntityTypeBuilder<OrderRecord> builder)
    {
        builder.ToTable("Orders");
        
        builder.ConfigureBaseEntity();
        
        builder.Property(o => o.OrderNumber).HasMaxLength(255).IsRequired();
        builder.Property(o => o.OrderDate).HasColumnType("date").IsRequired();
        
        builder.HasOne<ProviderRecord>()
            .WithMany()
            .HasForeignKey(p => p.ProviderId)
            .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasIndex(o => new { o.OrderNumber, o.ProviderId }).HasDatabaseName("IX_Orders_Number_ProviderId").IsUnique();
    }
}