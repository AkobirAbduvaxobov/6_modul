namespace GameStoreWebApp.Service.DTOs.Genre;

public class GenreCreateDTO
{
    public string Name { get; set; }
    public Guid? ParentGenreId { get; set; }
}
