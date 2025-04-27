using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.ResponseModels;
using GameStoreWebApp.Service.Services.ContentService;
using GameStoreWebApp.Service.Services.GameService;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace GameStoreWebApp.Api.Controllers;

/// <summary>
/// Controller for managing games.
/// </summary>
[ApiController]
public class GameController : ControllerBase
{
    private readonly IGameService _gameService;
    private readonly IContentService _contentService;

    public GameController(IGameService gameService, IContentService contentService)
    {
        _gameService = gameService;
        _contentService = contentService;
    }

    //[HttpPost("games/{key}/buy")]
    //public async Task<ActionResult> AddGameToCart(string key)
    //{
    //    await _gameService.AddGameToCartAsync(key);
    //    return Ok();
    //}

    /// <summary>
    /// Creates a new game.
    /// </summary>
    /// <param name="gameCreateDTO">The game data transfer object.</param>
    [HttpPost("games")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<GameDTO> PostGame(GameCreateRequest gameCreateRequest)
    {
        var gameDTO = await _gameService.PostGameAsync(gameCreateRequest);
        Response.StatusCode = StatusCodes.Status201Created;
        return gameDTO;
    }

    /// <summary>
    /// Gets a game by its key.
    /// </summary>
    /// <param name="key">The key of the game.</param>
    [HttpGet("games/{key}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GameDTO>> GetGameByKey(string key)
    {
        var gameDTO = await _gameService.GetGameByKeyAsync(key);
        return gameDTO;
    }

    /// <summary>
    /// Gets a game by its ID.
    /// </summary>
    /// <param name="id">The ID of the game.</param>
    [HttpGet("games/find/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<GameDTO>> GetGameById(Guid id)
    {
        var gameDTO = await _gameService.GetGameByIdAsync(id);
        return gameDTO;
    }

    /// <summary>
    /// Downloads a game by its key.
    /// </summary>
    /// <param name="key">The key of the game.</param>
    [HttpGet("games/{key}/file")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> DownloadGameByKey(string key)
    {
        var gameContent = await _contentService.DownloadGameByKeyAsync(key);

        var fileContent = Encoding.UTF8.GetString(gameContent.Content);
        var timestamp = DateTime.UtcNow.ToString("yyyyMMdd_HHmmss");
        var fileName = $"{gameContent.Name}_{timestamp}.txt";

        var stream = new MemoryStream(Encoding.UTF8.GetBytes(fileContent));
        var fileStreamResult = new FileStreamResult(stream, "text/plain")
        {
            FileDownloadName = fileName
        };

        return fileStreamResult;
    }


    /// <summary>
    /// Updates an existing game.
    /// </summary>
    /// <param name="gameUpdateDTO">The game data transfer object with updated information.</param>
    [HttpPut("games")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task PutGame(GameUpdateRequest gameUpdateRequest)
    {
        await _gameService.PutGameAsync(gameUpdateRequest);
        Response.StatusCode = StatusCodes.Status204NoContent;
    }

    /// <summary>
    /// Deletes a game by its key.
    /// </summary>
    /// <param name="key">The key of the game to delete.</param>
    [HttpDelete("games/{key}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task DeleteGame(string key)
    {
        await _gameService.DeleteGameByKeyAsync(key);
        Response.StatusCode = StatusCodes.Status204NoContent;
    }

    /// <summary>
    /// Gets all games.
    /// </summary>
    /// <returns>A list of all games.</returns>
    [HttpGet("games")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<FilteredGamesResponse> GetFilteredGames([FromQuery] GameFilterRequest gameFilterRequest)
    {
        var response = await _gameService.GetFilteredGamesAsync(gameFilterRequest);
        return response;
    }

    /// <summary>
    /// Gets all games.
    /// </summary>
    /// <returns>A list of all games.</returns>
    //[HttpGet("games")]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    //public async Task<ICollection<GameDTO>> GetAllGames()
    //{
    //    var gamesDTO = await _gameService.GetAllGamesAsync();
    //    return gamesDTO;
    //}

    /// <summary>
    /// Gets the genres associated with a game by its key.
    /// </summary>
    /// <param name="key">The key of the game.</param>
    [HttpGet("games/{key}/genres")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ICollection<GenreDTO>> GetGenresByGameKey(string key)
    {
        return await _gameService.GetAllGenresByGameKeyAsync(key);
    }

    /// <summary>
    /// Gets the platforms associated with a game by its key.
    /// </summary>
    /// <param name="key">The key of the game.</param>
    [HttpGet("games/{key}/platforms")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ICollection<PlatformDTO>> GetPlatformsByGameKey(string key)
    {
        return await _gameService.GetAllPlatformsByGameKeyAsync(key);
    }

    [HttpGet("games/{key}/publisher")]
    public async Task<PublisherDTO> GetPublisherByGameKey(string key)
    {
        var publisherDTO = await _gameService.GetPublisherByGameKeyAsync(key);
        return publisherDTO;
    }
}
