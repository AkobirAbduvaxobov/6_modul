using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class BanConfiguration : IEntityTypeConfiguration<Ban>
{
    public void Configure(EntityTypeBuilder<Ban> builder)
    {
        builder.HasKey(b => b.Id);
        builder.Property(b => b.BannedUntil).IsRequired();
    }
}
