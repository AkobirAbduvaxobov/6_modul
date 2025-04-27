using GameStoreWebApp.Service.DTOs.Comment;
using GameStoreWebApp.Service.DTOs.User;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.CommentService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class CommentController : ControllerBase
{
    private readonly ICommentService _commentService;

    public CommentController(ICommentService commentService)
    {
        _commentService = commentService;
    }

    [HttpPost("games/{key}/comments")]
    public async Task<CommentDTO> PostComment(string key, [FromBody] CommentCreateRequest request)
    {
        var commentDTO = await _commentService.PostCommentAsync(key, request);
        return commentDTO;
    }

    [HttpGet("comments/ban/durations")]
    public async Task<ICollection<string>> GellBanDurations()
    {
        var banDurations = await _commentService.GetBanDurationsAsync();
        return banDurations;
    }

    [HttpGet("games/{key}/comments")]
    public async Task<ICollection<CommentDTO>> GetCommentsByGameKey(string key)
    {
        var commentsDTO = await _commentService.GetCommentsByGameKeyAsync(key);
        return commentsDTO;
    }

    [HttpDelete("games/{key}/comments/{id}")]
    public async Task DeleteComment(string key, Guid id)
    {
        await _commentService.DeleteCommentByIdAsync(key, id);
    }

    [HttpPost("comments/ban")]
    public async Task BanUser(BanUserRequestDTO banUserRequestDTO)
    {
        await _commentService.BanUserAsync(banUserRequestDTO);
    }
}
