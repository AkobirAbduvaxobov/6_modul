using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using MongoDB.Driver;


namespace GameStoreWebApp.Repository.Services.GameService;

public class MongoGameRepository : IGameRepository
{
    private readonly IMongoCollection<Game> _gamesCollection;

    public MongoGameRepository(MongoDbContext dbContext)
    {
        _gamesCollection = dbContext.Games;
    }

    public async Task<Game> InsertGameAsync(Game game)
    {
        await _gamesCollection.InsertOneAsync(game);
        return game;
    }

    public async Task<Game> SelectGameByIdAsync(Guid id)
    {
        return await _gamesCollection.Find(g => g.Id == id).FirstOrDefaultAsync();
    }

    public async Task<Game> SelectGameByKeyAsync(string key)
    {
        return await _gamesCollection.Find(g => g.Key == key).FirstOrDefaultAsync();
    }

    public async Task<ICollection<Game>> SelectAllGamesAsync()
    {
        var res = await _gamesCollection.Find(g => true).ToListAsync();
        int x = 4 + 4;
        return res;
    }

    public async Task UpdateGameAsync(Game game)
    {
        await _gamesCollection.ReplaceOneAsync(g => g.Id == game.Id, game);
    }

    public async Task DeleteGameAsync(Game game)
    {
        await _gamesCollection.DeleteOneAsync(g => g.Id == game.Id);
    }

    public async Task<bool> CheckConsistingOfKeyAsync(string key)
    {
        return await _gamesCollection.Find(g => g.Key == key).AnyAsync();
    }

    // The following methods are not implemented because they either require
    // a different design approach or are not applicable in the context of MongoDB.
    public Task<Publisher> SelectPublisherByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<IQueryable<Game>> SelectAllGamesQueryAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Genre>> SelectAllGenresByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Platform>> SelectAllPlatformsByGameKeyAsync(string key)
    {
        throw new NotImplementedException();
    }

    int IGameRepository.SaveChanges()
    {
        throw new NotImplementedException();
    }
}
