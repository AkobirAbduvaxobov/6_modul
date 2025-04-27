using GameStoreWebApp.Service.DTOs.Comment;

namespace GameStoreWebApp.Service.RequestModels;

public class CommentCreateRequest
{
    public CommentCreateDTO Comment { get; set; }
    public Guid? ParentId { get; set; } 
    public string? Action { get; set; } 
}
