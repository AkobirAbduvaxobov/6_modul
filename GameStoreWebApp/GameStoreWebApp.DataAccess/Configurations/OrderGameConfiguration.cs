using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class OrderGameConfiguration : IEntityTypeConfiguration<OrderGame>
{
    public void Configure(EntityTypeBuilder<OrderGame> builder)
    {
        builder.HasKey(og => new { og.OrderId, og.ProductId });

        builder
            .Property(og => og.Price)
            .IsRequired();

        builder
            .Property(og => og.Quantity)
            .IsRequired();

        builder
            .HasOne(og => og.Order)
            .WithMany(o => o.OrderGames)
            .HasForeignKey(og => og.OrderId);

        builder
            .HasOne(og => og.Product)
            .WithMany()
            .HasForeignKey(og => og.ProductId);
    }
}
