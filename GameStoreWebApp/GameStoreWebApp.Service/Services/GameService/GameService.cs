using Azure.Core;
using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.GameService;
using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.ResponseModels;
using GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

namespace GameStoreWebApp.Service.Services.GameService;

public class GameService : IGameService
{
    private readonly IGameRepository _gameRepository;

    public GameService(IGameRepository gameRepository)
    {
        _gameRepository = gameRepository;
    }

    public async Task<GameDTO> GetGameByIdAsync(Guid id)
    {
        var gameEntity = await _gameRepository.SelectGameByIdAsync(id);

        if (gameEntity == null)
            throw new NotFoundException($"Game with ID {id} was not found.");

        var gameDTO = ConvertToGameDTO(gameEntity);
        return gameDTO;
    }

    public async Task<GameDTO> GetGameByKeyAsync(string key)
    {
        var gameEntity = await _gameRepository.SelectGameByKeyAsync(key);

        if (gameEntity == null)
            throw new NotFoundException($"Game with Key {key} was not found.");

        var gameDTO = ConvertToGameDTO(gameEntity);
        return gameDTO;
    }

    public async Task<GameDTO> PostGameAsync(GameCreateRequest gameCreateRequest)
    {
        if (gameCreateRequest == null)
            throw new ArgumentNullException(nameof(gameCreateRequest));

        if (gameCreateRequest.Genres == null)
            throw new ArgumentException("GenreIds cannot be null.", nameof(gameCreateRequest.Genres));

        if (gameCreateRequest.Platforms == null)
            throw new ArgumentException("PlatformIds cannot be null.", nameof(gameCreateRequest.Platforms));

        if (string.IsNullOrEmpty(gameCreateRequest.Game.Key))
        {
            var key = gameCreateRequest.Game.Name.ToLower().Replace(" ", "-") + "-key";
            var uniqueKey = key;
            var suffix = 1;

            var isGameKeyConsists = await _gameRepository.CheckConsistingOfKeyAsync(uniqueKey);

            while (isGameKeyConsists)
            {
                uniqueKey = $"{key}-{suffix++}";
                isGameKeyConsists = await _gameRepository.CheckConsistingOfKeyAsync(uniqueKey);
            }

            gameCreateRequest.Game.Key = uniqueKey;
        }

        var gameEntity = ConvertToGameEntity(gameCreateRequest);
        var gameEntityFromDb = await _gameRepository.InsertGameAsync(gameEntity);
        var gameDTO = ConvertToGameDTO(gameEntityFromDb);

        return gameDTO;
    }

    public async Task PutGameAsync(GameUpdateRequest gameUpdateRequest)
    {
        if (gameUpdateRequest == null)
            throw new NullReferenceException(nameof(gameUpdateRequest));

        if (gameUpdateRequest.Game.Id == Guid.Empty)
            throw new ArgumentException("Invalid game to update: Id cannot be empty", nameof(gameUpdateRequest.Game.Id));

        var gameEntity = await _gameRepository.SelectGameByIdAsync(gameUpdateRequest.Game.Id);

        if (gameEntity == null)
            throw new NotFoundException($"Game with Id {gameUpdateRequest.Game.Id} not found to update");

        gameEntity.Name = gameUpdateRequest.Game.Name;
        gameEntity.Description = gameUpdateRequest.Game.Description;
        gameEntity.Key = gameUpdateRequest.Game.Key;
        gameEntity.Price = gameUpdateRequest.Game.Price;    
        gameEntity.Discount = gameUpdateRequest.Game.Discount;
        gameEntity.UnitInStock = gameUpdateRequest.Game.UnitInStock;

        gameEntity.GameGenres = gameUpdateRequest.Genres
            .Select(genreId => new GameGenre { GameId = gameEntity.Id, GenreId = genreId })
            .ToList();

        gameEntity.GamePlatforms = gameUpdateRequest.Platforms
            .Select(platformId => new GamePlatform { GameId = gameEntity.Id, PlatformId = platformId })
            .ToList();

        gameEntity.PublishedDate = DateTime.UtcNow;

        await _gameRepository.UpdateGameAsync(gameEntity);
        _gameRepository.SaveChanges();
    }

    public async Task DeleteGameByKeyAsync(string key)
    {
        var gameEntity = await _gameRepository.SelectGameByKeyAsync(key);

        if (gameEntity == null)
            throw new NotFoundException($"Game with Key {key} not found to delete");

        await _gameRepository.DeleteGameAsync(gameEntity);
        _gameRepository.SaveChanges();
    }

    public async Task<ICollection<GameDTO>> GetAllGamesAsync()
    {
        var games = await _gameRepository.SelectAllGamesAsync();

        var gamesDTO = games.Select(g => ConvertToGameDTO(g)).ToList();

        return gamesDTO;
    }

    public async Task<ICollection<GenreDTO>> GetAllGenresByGameKeyAsync(string key)
    {
        var genres = await _gameRepository.SelectAllGenresByGameKeyAsync(key);

        var genresDTO = genres.Select(genre =>
            new GenreDTO { Id = genre.Id, Name = genre.Name }).ToList();

        return genresDTO;
    }

    public async Task<ICollection<PlatformDTO>> GetAllPlatformsByGameKeyAsync(string key)
    {
        var platforms = await _gameRepository.SelectAllPlatformsByGameKeyAsync(key);

        var platformDTO = platforms.Select(platform =>
            new PlatformDTO { Id = platform.Id, Type = platform.Type }).ToList();

        return platformDTO;
    }

    public async Task<FilteredGamesResponse> GetFilteredGamesAsync(GameFilterRequest gameFilterRequest)
    {
        var gamesQuery = await _gameRepository.SelectAllGamesQueryAsync();

        var pipeline = new GamePipeline()
            .AddStep(new GenreFilter())
            .AddStep(new PlatformFilter())
            .AddStep(new PublisherFilter())
            .AddStep(new PriceFilter())
            .AddStep(new NameFilter())
            .AddStep(new DatePublishingFilter())
            .AddStep(new Sorting())
            .AddStep(new Pagination());

        gamesQuery = pipeline.Execute(gamesQuery, gameFilterRequest);
        var filteredGames = gamesQuery.ToList();
        var gamesDTO = filteredGames.Select(g => ConvertToGameDTO(g)).ToList();

        var filteredGamesResponse = new FilteredGamesResponse()
        {
            FilteredGames = gamesDTO,
            CurrentPage = gameFilterRequest.Page,
            TotalPages = gameFilterRequest.PageCount,
        };

        return filteredGamesResponse;
    }

    private Game ConvertToGameEntity(GameCreateRequest gameCreateRequest)
    {
        var id = Guid.NewGuid();
        var game = new Game
        {
            Id = id,
            Name = gameCreateRequest.Game.Name,
            Key = gameCreateRequest.Game.Key,
            Description = gameCreateRequest.Game.Description,
            Price = gameCreateRequest.Game.Price,
            UnitInStock = gameCreateRequest.Game.UnitInStock,
            Discount = gameCreateRequest.Game.Discount,
            PublisherId = gameCreateRequest.Publisher,
            GameGenres = gameCreateRequest.Genres?.Select(genreId => new GameGenre { GameId = id, GenreId = genreId }).ToList(),
            GamePlatforms = gameCreateRequest.Platforms?.Select(platformId => new GamePlatform { GameId = id, PlatformId = platformId }).ToList()
        };

        return game;
    }

    private GameDTO ConvertToGameDTO(Game game)
    {
        var gameDTO = new GameDTO
        {
            Id = game.Id,
            Name = game.Name,
            Key = game.Key,
            Description = game.Description,
            Price = game.Price,
            UnitInStock = game.UnitInStock,
            Discount = game.Discount,
        };

        return gameDTO;
    }

    public async Task<PublisherDTO> GetPublisherByGameKeyAsync(string key)
    {
        var publisher = await _gameRepository.SelectPublisherByGameKeyAsync(key);

        var publisherDTO = new PublisherDTO()
        {
            Id = publisher.Id,
            CompanyName = publisher.CompanyName,
            Description = publisher.Description,
            HomePage = publisher.HomePage,
        };

        return publisherDTO;
    }
}
