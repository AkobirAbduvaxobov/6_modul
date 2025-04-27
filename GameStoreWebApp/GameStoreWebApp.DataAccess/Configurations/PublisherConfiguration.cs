using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.CompanyName).IsRequired().HasMaxLength(100);
        builder.HasIndex(p => p.CompanyName).IsUnique();
        builder.Property(p => p.HomePage).IsRequired(false);
        builder.Property(p => p.Description).IsRequired(false);

        builder
            .HasMany(p => p.Games)
            .WithOne(g => g.Publisher)
            .HasForeignKey(g => g.PublisherId);
    }
}
