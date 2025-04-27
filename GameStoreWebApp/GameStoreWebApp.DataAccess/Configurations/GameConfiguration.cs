using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.Name).IsRequired();
        builder.Property(g => g.Key).IsRequired();
        builder.HasIndex(g => g.Key).IsUnique();
        builder.Property(g => g.Price).IsRequired();
        builder.Property(g => g.UnitInStock).IsRequired();
        builder.Property(g => g.Discount).IsRequired();
        builder.Property(g => g.Description).IsRequired(false);

        builder
            .HasMany(g => g.GameGenres)
            .WithOne(gg => gg.Game)
            .HasForeignKey(gg => gg.GameId);

        builder
            .HasMany(g => g.GamePlatforms)
            .WithOne(gp => gp.Game)
            .HasForeignKey(gp => gp.GameId);

        builder
            .HasOne(g => g.Publisher)
            .WithMany(p => p.Games)
            .HasForeignKey(g => g.PublisherId)
            .IsRequired();
    }
}
