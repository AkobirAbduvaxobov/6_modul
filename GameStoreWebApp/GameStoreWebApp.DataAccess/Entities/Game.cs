namespace GameStoreWebApp.DataAccess.Entities;

public class Game
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int UnitInStock { get; set; }
    public int Discount { get; set; }
    public Guid PublisherId { get; set; }
    public DateTime PublishedDate { get; set; }

    public Publisher Publisher { get; set; }
    public ICollection<GameGenre> GameGenres { get; set; }
    public ICollection<GamePlatform> GamePlatforms { get; set; }
    public ICollection<Comment> Comments { get; set; }
}
