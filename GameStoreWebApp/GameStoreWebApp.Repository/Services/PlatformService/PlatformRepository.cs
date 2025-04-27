using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.PlatformService;

public class PlatformRepository : IPlatformRepository
{
    private MainContext _dbContext;

    public PlatformRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Platform> InsertPlatformAsync(Platform platform)
    {
        var platformEntity = await _dbContext.Platforms.AddAsync(platform);

        await _dbContext.SaveChangesAsync();

        return platformEntity.Entity;
    }

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<Platform> SelectPlatformByIdAsync(Guid id)
    {
        return await _dbContext.Platforms.FirstOrDefaultAsync(p => p.Id == id);    
    }

    public async Task<ICollection<Platform>> SelectAllPlatformsAsync()
    {
        var platforms = _dbContext.Platforms.ToList();
        return platforms;
    }

    public async Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid id)
    {
        var query = _dbContext.Platforms.Include(g => g.GamePlatforms)
                                        .ThenInclude(gg => gg.Game);

        var paltform = await query.FirstOrDefaultAsync(ge => ge.Id == id);

        if (paltform == null)
            throw new NotFoundException($"Paltform with ID {id} was not found.");

        var games = paltform.GamePlatforms.Select(gp => gp.Game).ToList();

        return games;
    }

    public async Task UpdatePlatformAsync(Platform platform)
    {
        if (_dbContext.Entry(platform).State != EntityState.Modified)
        {
            _dbContext.Platforms.Update(platform);
        }
    }

    public async Task DeletePlatformAsync(Platform platform)
    {
        if (_dbContext.Entry(platform).State != EntityState.Deleted)
        {
            _dbContext.Platforms.Remove(platform);
        }
    }
}
