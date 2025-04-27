using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.HasKey(g => g.Id);
        builder.Property(g => g.Name).IsRequired();
        builder.HasIndex(g => g.Name).IsUnique();

        builder
            .HasOne(g => g.ParentGenre)
            .WithMany(g => g.SubGenres)
            .HasForeignKey(g => g.ParentGenreId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(g => g.GameGenres)
            .WithOne(gg => gg.Genre)
            .HasForeignKey(gg => gg.GenreId);
    }
}
