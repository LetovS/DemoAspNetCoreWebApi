using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities;
using Store.EntitiesConfiguration.Extensions;

namespace Store.EntitiesConfiguration;

public class ProviderConfiguration : IEntityTypeConfiguration<ProviderRecord>
{
    private const string NameConstraint = "UQ_Providers_Name";
    
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