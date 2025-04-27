using GameStoreWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.GameCountService;

public class GameCountRepository : IGameCountRepository
{
    private MainContext _dbContext;

    public GameCountRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> GetGameCountAsync()
    {
        return await _dbContext.Games.CountAsync();
    }
}
