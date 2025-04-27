namespace GameStoreWebApp.DataAccess.Entities;

public class Comment
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Body { get; set; }
    public Guid? ParentCommentId { get; set; }
    public Guid GameId { get; set; }

    public Game Game { get; set; }
    public Comment ParentComment { get; set; }
    public ICollection<Comment> Replies { get; set; }
}