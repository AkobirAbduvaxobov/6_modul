using GameStoreWebApp.Service.Services.GameFilterOptionsService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class FilterOptionsController : ControllerBase
{
    private readonly IGameFilterOptionsService _gameFilterOptionsService;

    public FilterOptionsController(IGameFilterOptionsService gameFilterOptionsService)
    {
        _gameFilterOptionsService = gameFilterOptionsService;
    }

    [HttpGet("games/pagination-options")]
    public async Task<ICollection<string>> GetPaginationOptions()
    {
        var response = await _gameFilterOptionsService.GetPaginationOptionsAsync();
        return response;
    }

    [HttpGet("games/sorting-options")]
    public async Task<ICollection<string>> GetSortingOptions()
    {
        var response = await _gameFilterOptionsService.GetSortingOptionsAsync();
        return response;
    }

    [HttpGet("games/publish-date-options")]
    public async Task<ICollection<string>> GetPublishedDateFilterOptions()
    {
        var response = await _gameFilterOptionsService.GetPublishedDateFilterOptionsAsync();
        return response;
    }
}
