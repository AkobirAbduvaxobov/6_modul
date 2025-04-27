using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.CommentService;
using GameStoreWebApp.Repository.Services.GameService;
using GameStoreWebApp.Service.DTOs.Comment;
using GameStoreWebApp.Service.DTOs.User;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.CommentService;

public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;
    private readonly IGameRepository _gameRepository;

    public CommentService(ICommentRepository commentRepository, IGameRepository gameRepository)
    {
        _commentRepository = commentRepository;
        _gameRepository = gameRepository;
    }

    public async Task BanUserAsync(BanUserRequestDTO banUserRequestDTO)
    {
        var banDurationExists = await _commentRepository.BanDurationExistsAsync(banUserRequestDTO.Duration);
        if (banDurationExists is false)
        {
            throw new NotFoundException($"Ban duration with period {banUserRequestDTO.Duration} was not found.");
        }

        var banTimeSpan = banUserRequestDTO.Duration.ToLower() switch
        {
            "1 hour" => TimeSpan.FromHours(1),
            "1 day" => TimeSpan.FromDays(1),
            "1 week" => TimeSpan.FromDays(7),
            "1 month" => TimeSpan.FromDays(30), 
            "permanent" => TimeSpan.MaxValue,
            _ => throw new ArgumentException("Invalid ban duration.")
        };

        var bannedUntil = banTimeSpan == TimeSpan.MaxValue
            ? DateTime.MaxValue
            : DateTime.UtcNow.Add(banTimeSpan);

        var banEntity = new Ban()
        {
            Id = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            BannedUntil = bannedUntil
        };

        await _commentRepository.BanUserAsync(banEntity);
    }

    public async Task DeleteCommentByIdAsync(string key, Guid id)
    {
        var gameEntity = await _gameRepository.SelectGameByKeyAsync(key);
        if (gameEntity == null)
        {
            throw new NotFoundException($"Game with key {key} was not found.");
        }

        var comment = await _commentRepository.SelectCommentsByIdAsync(id);
        if (comment == null)
        {
            throw new NotFoundException($"Comment with ID {id} was not found.");
        }

        comment.Body = "A comment/quote was deleted";
        await _commentRepository.UpdateCommentAsync(comment);

        var quotedComments = await _commentRepository.SelectCommentsThatQuoteDeletedCommentAsync(id);
        foreach (var quotedComment in quotedComments)
        {
            quotedComment.Body = "A comment/quote was deleted";
            await _commentRepository.UpdateCommentAsync(quotedComment);
        }
    }

    public async Task<ICollection<string>> GetBanDurationsAsync()
    {
        var banDurationEntities = await _commentRepository.SelectBanDurationsAsync();
        var banDuration = banDurationEntities.Select(b => b.Duration).ToList();
        return banDuration;
    }

    public async Task<ICollection<CommentDTO>> GetCommentsByGameKeyAsync(string key)
    {
        var commentEntities = await _commentRepository.SelectCommentsByGameKeyAsync(key);

        var commentDTOs = commentEntities.Select(comment => ConvertToCammentDTO(comment)).ToList();

        return commentDTOs;
    }

    public async Task<CommentDTO> PostCommentAsync(string key, CommentCreateRequest commentCreateRequest)
    {

        var game = await _gameRepository.SelectGameByKeyAsync(key);
        if (game == null)
        {
            throw new NotFoundException($"Game with key {key} was not found.");
        }

        var formattedBody = commentCreateRequest.Comment.Body;

        if (commentCreateRequest.ParentId.HasValue)
        {
            var parentComment = await _commentRepository.SelectCommentsByIdAsync(commentCreateRequest.ParentId.Value);
            if (parentComment == null)
            {
                throw new NotFoundException($"Parent comment with ID {commentCreateRequest.ParentId} was not found.");
            }

            if (commentCreateRequest.Action == "quote")
            {
                formattedBody = $"[{parentComment.Body}], {commentCreateRequest.Comment.Body}";
            }
            else
            {
                formattedBody = $"[{parentComment.Name}], {commentCreateRequest.Comment.Body}";
            }
        }

        var commentEntity = new Comment
        {
            Id = Guid.NewGuid(),
            Name = commentCreateRequest.Comment.Name,
            Body = formattedBody,
            ParentCommentId = commentCreateRequest.ParentId,
            GameId = game.Id
        };

        var commentEntityFromDb = await _commentRepository.InsertCommentAsync(commentEntity);
        var commentDTO = ConvertToCammentDTO(commentEntity);
        return commentDTO;
    }

    private CommentDTO ConvertToCammentDTO(Comment comment)
    {
        return new CommentDTO
        {
            Id = comment.Id,
            Name = comment.Name,
            Body = comment.Body,
            ChildComments = comment.Replies?.Select(ConvertToCammentDTO).ToList()
        };
    }

}
