using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.PlatformService;

public interface IPlatformRepository
{
    Task<ICollection<Game>> SelectGamesByPlatformIdAsync(Guid id);
    Task<Platform> InsertPlatformAsync(Platform platform);
    Task<Platform> SelectPlatformByIdAsync(Guid id);
    Task<ICollection<Platform>> SelectAllPlatformsAsync();
    Task UpdatePlatformAsync(Platform platform);
    Task DeletePlatformAsync(Platform platform);
    int SaveChanges();
}
