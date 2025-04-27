using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.ContentService;

public class ContentRepository : IContentRepository
{
    private MainContext _dbContext;

    public ContentRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<Game> SelectGameByKeyAsync(string key)
    {
        var gameEntity =  await _dbContext.Games.FirstOrDefaultAsync(g => g.Key == key);
        return gameEntity;
    }
}
