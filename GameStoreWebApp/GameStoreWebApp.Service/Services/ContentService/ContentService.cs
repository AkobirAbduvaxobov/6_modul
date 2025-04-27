using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.ContentService;
using GameStoreWebApp.Service.DTOs.Game;
using Newtonsoft.Json;
using System.Text;
using System.Xml;

namespace GameStoreWebApp.Service.Services.ContentService;

public class ContentService : IContentService
{
    private readonly IContentRepository _contentRepository;

    public ContentService(IContentRepository contentRepository)
    {
        _contentRepository = contentRepository;
    }

    public async Task<GameContentDTO> DownloadGameByKeyAsync(string key)
    {
        var game = await _contentRepository.SelectGameByKeyAsync(key);

        if (game == null)
            throw new NotFoundException($"Game with Key {key} not found to download");

        var jsonString = JsonConvert.SerializeObject(game);

        var byteArray = Encoding.UTF8.GetBytes(jsonString);

        var gameContent = new GameContentDTO()
        {
            Name = game.Name,
            Content = byteArray
        };

        return gameContent;
    }
}
