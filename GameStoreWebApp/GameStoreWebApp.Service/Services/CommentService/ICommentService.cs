using GameStoreWebApp.Service.DTOs.Comment;
using GameStoreWebApp.Service.DTOs.User;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.CommentService;

public interface ICommentService
{
    Task<CommentDTO> PostCommentAsync(string key, CommentCreateRequest commentCreateRequest);
    Task<ICollection<string>> GetBanDurationsAsync();
    Task<ICollection<CommentDTO>> GetCommentsByGameKeyAsync(string key);
    Task DeleteCommentByIdAsync(string key, Guid id);
    Task BanUserAsync(BanUserRequestDTO banUserRequestDTO);
}
