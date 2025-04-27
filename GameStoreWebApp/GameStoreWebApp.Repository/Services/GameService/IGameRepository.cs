using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.GameService;

public interface IGameRepository
{
    Task<Game> InsertGameAsync(Game game);
    Task<bool> CheckConsistingOfKeyAsync(string key);
    Task<Game> SelectGameByKeyAsync(string key);
    Task<Game> SelectGameByIdAsync(Guid id);
    Task UpdateGameAsync(Game game);
    Task DeleteGameAsync(Game game);
    Task<Publisher> SelectPublisherByGameKeyAsync(string key);
    Task<ICollection<Game>> SelectAllGamesAsync();
    Task<IQueryable<Game>> SelectAllGamesQueryAsync();
    Task<ICollection<Genre>> SelectAllGenresByGameKeyAsync(string key);
    Task<ICollection<Platform>> SelectAllPlatformsByGameKeyAsync(string key);
    int SaveChanges();
}
