using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GenreService;

public interface IGenreService
{
    Task<ICollection<GameDTO>> GetGamesByGenreIdAsync(Guid id);
    Task<GenreDTO> PostGenreAsync(GenreCreateRequest genreCreateRequest);
    Task<GenreDTO> GetGenreByIdAsync(Guid id);
    Task<ICollection<GenreDTO>> GetGenresAsync();
    Task<ICollection<GenreDTO>> GetAllGenresByParentIdAsync(Guid id);
    Task PutGenreAsync(GenreUpdateRequest genreUpdateRequest);
    Task DeleteGenreByIdAsync(Guid id);
}
