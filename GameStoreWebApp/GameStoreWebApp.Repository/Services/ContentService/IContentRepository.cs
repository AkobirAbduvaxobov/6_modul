using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.ContentService;

public interface IContentRepository
{
    Task<Game> SelectGameByKeyAsync(string key);
}
