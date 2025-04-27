namespace GameStoreWebApp.DataAccess.Entities;

public class Genre
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid? ParentGenreId { get; set; }

    public Genre ParentGenre { get; set; }
    public ICollection<Genre> SubGenres { get; set; }
    public ICollection<GameGenre> GameGenres { get; set; }
}
