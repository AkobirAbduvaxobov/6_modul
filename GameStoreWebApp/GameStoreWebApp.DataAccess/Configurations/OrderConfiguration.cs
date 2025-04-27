using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GameStoreWebApp.DataAccess.Configurations;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(o => o.Id);

        builder
            .Property(o => o.Status)
            .IsRequired();

        builder
            .Property(o => o.CustomerId)
            .IsRequired();

        builder
            .Property(o => o.Date)
            .HasDefaultValueSql("GETUTCDATE()"); 

        builder
            .HasMany(o => o.OrderGames)
            .WithOne(og => og.Order)
            .HasForeignKey(og => og.OrderId);
    }
}
