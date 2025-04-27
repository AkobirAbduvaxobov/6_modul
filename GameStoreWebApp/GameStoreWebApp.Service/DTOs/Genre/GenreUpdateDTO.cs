namespace GameStoreWebApp.Service.DTOs.Genre;

public class GenreUpdateDTO
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid? ParentGenreId { get; set; }
}
