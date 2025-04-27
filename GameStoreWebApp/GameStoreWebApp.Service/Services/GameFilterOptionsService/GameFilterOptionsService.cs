
using GameStoreWebApp.Repository.Services.GameFilterOptionsService;

namespace GameStoreWebApp.Service.Services.GameFilterOptionsService;

public class GameFilterOptionsService : IGameFilterOptionsService
{
    private readonly IGameFilterOptionsRepository _gameFilterOptionsRepository;

    public GameFilterOptionsService(IGameFilterOptionsRepository gameFilterOptionsRepository)
    {
        _gameFilterOptionsRepository = gameFilterOptionsRepository;
    }

    public async Task<ICollection<string>> GetPaginationOptionsAsync()
    {
        var paginationOptions = await _gameFilterOptionsRepository.SelectPaginationOptionsAsync();
        var options = new List<string>();
        foreach (var option in paginationOptions)
        {
            options.Add(option.Option);
        }

        return options;
    }

    public async Task<ICollection<string>> GetPublishedDateFilterOptionsAsync()
    {
        var filterOptions = await _gameFilterOptionsRepository.SelectPublishedDateFilterOptionsAsync();
        var options = new List<string>();
        foreach (var option in filterOptions)
        {
            options.Add(option.Option);
        }

        return options;
    }

    public async Task<ICollection<string>> GetSortingOptionsAsync()
    {
        var sortingOptions = await _gameFilterOptionsRepository.SelectSortingOptionsAsync();
        var options = new List<string>();
        foreach (var option in sortingOptions)
        {
            options.Add(option.Option);
        }

        return options;
    }
}
