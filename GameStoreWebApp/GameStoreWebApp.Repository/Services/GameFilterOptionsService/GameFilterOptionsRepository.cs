using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.GameFilterOptionsService;

public class GameFilterOptionsRepository : IGameFilterOptionsRepository
{
    private MainContext _dbContext;

    public GameFilterOptionsRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<PaginationOption>> SelectPaginationOptionsAsync()
    {
        return await _dbContext.PaginationOptions.ToListAsync();
    }

    public async Task<ICollection<PublishedDateFilterOption>> SelectPublishedDateFilterOptionsAsync()
    {
        return await _dbContext.PublishedDateFilterOptions.ToListAsync();
    }

    public async Task<ICollection<SortingOption>> SelectSortingOptionsAsync()
    {
        return await _dbContext.SortingOptions.ToListAsync();
    }
}
