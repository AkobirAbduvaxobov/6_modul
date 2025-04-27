namespace GameStoreWebApp.Service.DTOs.Comment;

public class CommentDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Body { get; set; }
    public List<CommentDTO> ChildComments { get; set; } = new List<CommentDTO>();
}
        