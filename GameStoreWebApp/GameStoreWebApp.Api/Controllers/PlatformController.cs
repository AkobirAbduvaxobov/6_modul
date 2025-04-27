using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.PlatformService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class PlatformController : ControllerBase
{
    private readonly IPlatformService _platformService;

    public PlatformController(IPlatformService platformService)
    {
        _platformService = platformService;
    }

    [HttpGet("platforms/{id}/games")]
    public Task<ICollection<GameDTO>> GetGamesByPlatformId(Guid id)
    {
        var gamesDTO = _platformService.GetGamesByPlatformIdAsync(id);
        return gamesDTO;
    }

    [HttpPost("platforms")]
    public async Task<PlatformDTO> PostPlatform(PlatformCreateRequest platformCreateRequest)
    {
        var platformDTO = await _platformService.PostPlatformAsync(platformCreateRequest);
        return platformDTO;
    }

    [HttpGet("platforms/{id}")]
    public async Task<PlatformDTO> GetPlatformById(Guid id)
    {
        return await _platformService.GetPlatformByIdAsync(id);
    }

    [HttpGet("platforms")]
    public async Task<ICollection<PlatformDTO>> GetAllPlatforms()
    {
        return await _platformService.GetAllPlatformsAsync();
    }

    [HttpPut("platforms")]
    public async Task PutPlatform(PlatfromUpdateRequest platformUpdateRequest)
    {
        await _platformService.PutPlatfromAsync(platformUpdateRequest);
    }

    [HttpDelete("platforms/{id}")]
    public async Task DeletePlatformById(Guid id)
    {
        await _platformService.DeletePlatfromByIdAsync(id);
    }
}
