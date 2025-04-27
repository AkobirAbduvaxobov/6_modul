using GameStoreWebApp.Service.DTOs.Game;

namespace GameStoreWebApp.Service.Services.ContentService;

public interface IContentService
{
    Task<GameContentDTO> DownloadGameByKeyAsync(string key);
}
