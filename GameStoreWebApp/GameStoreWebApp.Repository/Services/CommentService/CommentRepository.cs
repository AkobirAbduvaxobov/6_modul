using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.CommentService;

public class CommentRepository : ICommentRepository
{
    private MainContext _dbContext;

    public CommentRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<bool> BanDurationExistsAsync(string duration)
    {
        return await _dbContext.BanDurations.AnyAsync(x => x.Duration == duration);
    }

    public async Task BanUserAsync(Ban ban)
    {
        await _dbContext.Bans.AddAsync(ban);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<Comment> InsertCommentAsync(Comment comment)
    {
        var commentEntity = await _dbContext.Comments.AddAsync(comment);

        await _dbContext.SaveChangesAsync();

        return commentEntity.Entity;
    }

    public async Task<ICollection<BanDuration>> SelectBanDurationsAsync()
    {
        return await _dbContext.BanDurations.ToListAsync();
    }

    public async Task<ICollection<Comment>> SelectCommentsByGameKeyAsync(string key)
    {
        var game = await _dbContext.Games.FirstOrDefaultAsync(game => game.Key == key);
        if (game == null)
        {
            throw new NotFoundException($"Game with key {key} was not found.");
        }

        var comments = await _dbContext.Comments
            .Where(c => c.GameId == game.Id && c.ParentCommentId == null)
            .ToListAsync();

        foreach (var comment in comments)
        {
            await LoadRepliesRecursively(comment);
        }

        return comments;
    }

    private async Task LoadRepliesRecursively(Comment comment)
    {
        if (comment is null)
        {
            return;
        }

        await _dbContext.Entry(comment)
            .Collection(c => c.Replies)
            .Query()
            .LoadAsync();

        foreach (var reply in comment.Replies)
        {
            await LoadRepliesRecursively(reply);
        }
    }


    public async Task<Comment> SelectCommentsByIdAsync(Guid id)
    {
        return await _dbContext.Comments.FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<ICollection<Comment>> SelectCommentsThatQuoteDeletedCommentAsync(Guid parentCommentId)
    {
        return await _dbContext.Comments
            .Where(c => c.ParentCommentId == parentCommentId)
            .ToListAsync();
    }

    public async Task UpdateCommentAsync(Comment comment)
    {
        _dbContext.Comments.Update(comment);
        await _dbContext.SaveChangesAsync();
    }
}
