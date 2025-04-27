using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.GenreService;

public interface IGenreRepository
{
    Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid id);
    Task<Genre> InsertGenreAsync(Genre genre);
    int SaveChanges();
    Task<Genre> SelectGenreByIdAsync(Guid id);
    Task<ICollection<Genre>> SelectAllGenresAsync();
    Task<ICollection<Genre>> SelectAllGenresByParentIdAsync(Guid id);
    Task UpdateGenreAsync(Genre genre);
    Task DeleteGenreAsync(Genre genre);
}
