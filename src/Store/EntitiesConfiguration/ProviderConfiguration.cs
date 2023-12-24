using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using Store.EntitiesConfiguration.Extensions;

namespace Store.EntitiesConfiguration;

/// <summary>
/// Конфигурирование провайдера
/// </summary>
public class ProviderConfiguration : IEntityTypeConfiguration<ProviderRecord>
{
    private const string NameConstraint = "UQ_Providers_Name";

    /// <inheritdoc/>
    public void Configure(EntityTypeBuilder<ProviderRecord> builder)
    {
        builder.ToTable("Providers");
        
        builder.ConfigureBaseEntity();

        builder.Property(conf => conf.ProviderName).HasMaxLength(255).IsRequired();
        
        builder.HasIndex(p => p.ProviderName)
            .HasDatabaseName(NameConstraint)
            .IsUnique();
    }
}