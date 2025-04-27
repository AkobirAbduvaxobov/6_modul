using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.PlatformService;

public interface IPlatformService
{
    Task<ICollection<GameDTO>> GetGamesByPlatformIdAsync(Guid id);
    Task<PlatformDTO> PostPlatformAsync(PlatformCreateRequest platformCreateRequest);
    Task<PlatformDTO> GetPlatformByIdAsync(Guid id);
    Task<ICollection<PlatformDTO>> GetAllPlatformsAsync();
    Task PutPlatfromAsync(PlatfromUpdateRequest platformUpdateRequest);
    Task DeletePlatfromByIdAsync(Guid id);
}
