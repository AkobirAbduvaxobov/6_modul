using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name).IsRequired();
        builder.Property(c => c.Body).IsRequired();
        builder.Property(c => c.ParentCommentId).IsRequired(false);

        builder
            .HasOne(c => c.Game)
            .WithMany(g => g.Comments)
            .HasForeignKey(c => c.GameId)
            .IsRequired();

        builder
            .HasOne(c => c.ParentComment)
            .WithMany(pc => pc.Replies)
            .HasForeignKey(c => c.ParentCommentId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasIndex(c => new { c.GameId, c.ParentCommentId });
    }
}
