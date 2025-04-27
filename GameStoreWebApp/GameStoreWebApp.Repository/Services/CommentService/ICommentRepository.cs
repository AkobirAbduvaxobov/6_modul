using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.CommentService;

public interface ICommentRepository
{
    Task<Comment> InsertCommentAsync(Comment comment);
    Task<ICollection<BanDuration>> SelectBanDurationsAsync();
    Task<ICollection<Comment>> SelectCommentsByGameKeyAsync(string key);
    Task<Comment> SelectCommentsByIdAsync(Guid id);
    Task UpdateCommentAsync(Comment comment);
    Task<ICollection<Comment>> SelectCommentsThatQuoteDeletedCommentAsync(Guid parentCommentId);
    Task<bool> BanDurationExistsAsync(string duration);
    Task BanUserAsync(Ban ban);

}
