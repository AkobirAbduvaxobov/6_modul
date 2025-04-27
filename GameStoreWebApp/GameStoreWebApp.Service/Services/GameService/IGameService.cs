using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.ResponseModels;

namespace GameStoreWebApp.Service.Services.GameService;

public interface IGameService
{
    Task<GameDTO> PostGameAsync(GameCreateRequest gameCreateRequest);
    Task<GameDTO> GetGameByKeyAsync(string key);
    Task<GameDTO> GetGameByIdAsync(Guid id);
    Task PutGameAsync(GameUpdateRequest gameUpdateRequest);
    Task DeleteGameByKeyAsync(string key);
    Task<PublisherDTO> GetPublisherByGameKeyAsync(string key);
    Task<ICollection<GameDTO>> GetAllGamesAsync();
    Task<FilteredGamesResponse> GetFilteredGamesAsync(GameFilterRequest gameFilterRequest);
    Task<ICollection<GenreDTO>> GetAllGenresByGameKeyAsync(string key);
    Task<ICollection<PlatformDTO>> GetAllPlatformsByGameKeyAsync(string key);
}
