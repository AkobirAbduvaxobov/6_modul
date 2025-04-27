using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Type).IsRequired();
        builder.HasIndex(p => p.Type).IsUnique();

        builder
            .HasMany(p => p.GamePlatforms)
            .WithOne(gp => gp.Platform)
            .HasForeignKey(gp => gp.PlatformId);
    }
}
