using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.GameService;

public class GameRepository : IGameRepository
{
    private MainContext _dbContext;

    public GameRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task DeleteGameAsync(Game game)
    {
        if (_dbContext.Entry(game).State != EntityState.Deleted)
        {
            _dbContext.Games.Remove(game);
        }
    }

    public async Task<ICollection<Game>> SelectAllGamesAsync()
    {
        var games = _dbContext.Games.ToList();
        return games;
    }

    public async Task<Game> InsertGameAsync(Game game)
    {
        var gameEntity = await _dbContext.Games.AddAsync(game);
        
        await _dbContext.SaveChangesAsync();

        return gameEntity.Entity;
    }

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<Game> SelectGameByIdAsync(Guid id)
    {
        return await _dbContext.Games.FirstOrDefaultAsync(g => g.Id == id);
    }

    public async Task<Game> SelectGameByKeyAsync(string key)
    {
        return await _dbContext.Games.FirstOrDefaultAsync(g => g.Key == key);
    }

    public async Task UpdateGameAsync(Game game)
    {
        if (_dbContext.Entry(game).State != EntityState.Modified)
        {
            _dbContext.Games.Update(game);
        }
    }

    public async Task<ICollection<Genre>> SelectAllGenresByGameKeyAsync(string key)
    {
        var genres = await _dbContext.Games
            .Where(g => g.Key == key)
            .SelectMany(g => g.GameGenres)
            .Select(gg => gg.Genre)
            .ToListAsync();

        return genres;
    }

    public async Task<ICollection<Platform>> SelectAllPlatformsByGameKeyAsync(string key)
    {
        var platforms = await _dbContext.Games
            .Where(g => g.Key == key)
            .SelectMany(g => g.GamePlatforms)
            .Select(gg => gg.Platform)
            .ToListAsync();

        return platforms;
    }

    public async Task<bool> CheckConsistingOfKeyAsync(string key)
    {
        var resFromDB =  await _dbContext.Games.AnyAsync(g => g.Key == key);
        
        return resFromDB;
    }

    public async Task<Publisher> SelectPublisherByGameKeyAsync(string key)
    {
        var game = await _dbContext.Games
            .Include(g => g.Publisher)
            .FirstOrDefaultAsync(g=> g.Key == key);

        if(game == null)
            throw new NotFoundException($"Game with Key {key} was not found.");

        return game.Publisher;
    }

    public async Task<IQueryable<Game>> SelectAllGamesQueryAsync()
    {
        IQueryable<Game> games = _dbContext.Games
            .Include(g => g.GameGenres)
            .Include(g => g.GamePlatforms)
            .Include(g => g.Publisher);

        return games;
    }
}
