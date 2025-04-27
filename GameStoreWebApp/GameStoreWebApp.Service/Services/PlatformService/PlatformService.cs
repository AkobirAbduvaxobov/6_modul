using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.PlatformService;
using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.PlatformService;

public class PlatformService : IPlatformService
{
    private readonly IPlatformRepository _platformRepository;

    public PlatformService(IPlatformRepository platformRepository)
    {
        _platformRepository = platformRepository;
    }

    public async Task<ICollection<PlatformDTO>> GetAllPlatformsAsync()
    {
        var platformsEntity = await _platformRepository.SelectAllPlatformsAsync();

        var platformDTOs = platformsEntity.Select(pl => new PlatformDTO() { Id = pl.Id, Type = pl.Type }).ToList();

        return platformDTOs;
    }

    public async Task<PlatformDTO> GetPlatformByIdAsync(Guid id)
    {
        var platformEntity = await _platformRepository.SelectPlatformByIdAsync(id);

        if(platformEntity == null)
            throw new NotFoundException($"Platform with Id {id} was not found.");

        var platformDTO = new PlatformDTO()
        {
            Id = platformEntity.Id,
            Type = platformEntity.Type,
        };

        return platformDTO;
    }

    public async Task<ICollection<GameDTO>> GetGamesByPlatformIdAsync(Guid id)
    {
        var games = await _platformRepository.SelectGamesByPlatformIdAsync(id);

        var gamesDTO = games.Select(g => new GameDTO { Id = g.Id, Name = g.Name, Key = g.Key }).ToList();

        return gamesDTO;
    }

    public async Task<PlatformDTO> PostPlatformAsync(PlatformCreateRequest platformCreateRequest)
    {
        if (platformCreateRequest == null || platformCreateRequest.Platform is null)
            throw new NullReferenceException(nameof(platformCreateRequest));

        var platformEntity = new Platform()
        {
            Id = new Guid(),
            Type = platformCreateRequest.Platform.Type,
        };

        var platfromEntityFromDb = await _platformRepository.InsertPlatformAsync(platformEntity);
        var platformDTO = new PlatformDTO()
        {
            Id = platformEntity.Id,
            Type = platformEntity.Type,
        };

        return platformDTO;
    }

    public async Task PutPlatfromAsync(PlatfromUpdateRequest platformUpdateRequest)
    {
        if(platformUpdateRequest == null || platformUpdateRequest.Platform == null)
            throw new NullReferenceException( nameof(platformUpdateRequest));

        var platformEntity = await _platformRepository.SelectPlatformByIdAsync(platformUpdateRequest.Platform.Id);

        if(platformEntity == null)
            throw new NotFoundException($"Platform with Id {platformUpdateRequest.Platform.Id} not found to update");

        platformEntity.Type = platformUpdateRequest.Platform.Type;

        await _platformRepository.UpdatePlatformAsync(platformEntity);  
        _platformRepository.SaveChanges();
    }

    public async Task DeletePlatfromByIdAsync(Guid id)
    {
        var platformEntity = await _platformRepository.SelectPlatformByIdAsync(id);

        if(platformEntity == null)
            throw new NotFoundException($"Platform with Id {id} not found to delete");

        await _platformRepository.DeletePlatformAsync(platformEntity);
        _platformRepository.SaveChanges();
    }
}
