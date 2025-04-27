using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.GenreService;
using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GenreService;

public class GenreService : IGenreService
{
    private readonly IGenreRepository _genreRepository;

    public GenreService(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;
    }

    public async Task DeleteGenreByIdAsync(Guid id)
    {
        var genreEntity = await _genreRepository.SelectGenreByIdAsync(id);

        if (genreEntity == null)
            throw new NotFoundException($"Genre with Id {id} not found to delete");

        await _genreRepository.DeleteGenreAsync(genreEntity);
        _genreRepository.SaveChanges();
    }

    public async Task<ICollection<GenreDTO>> GetAllGenresByParentIdAsync(Guid id)
    {
        var genres = await _genreRepository.SelectAllGenresByParentIdAsync(id);

        var genresDTO = genres.Select(genres =>
            new GenreDTO { Id = genres.Id, Name = genres.Name }).ToList();

        return genresDTO;
    }

    public async Task<ICollection<GameDTO>> GetGamesByGenreIdAsync(Guid id)
    {
        var games = await _genreRepository.SelectGamesByGenreIdAsync(id);

        var gamesDTO = games.Select(g => new GameDTO { Id = g.Id, Name = g.Name, Key = g.Key }).ToList();

        return gamesDTO;
    }

    public async Task<GenreDTO> GetGenreByIdAsync(Guid id)
    {
        var genre = await _genreRepository.SelectGenreByIdAsync(id);

        if (genre == null)
            throw new NotFoundException($"Genre with Id {id} was not found.");

        var genreDTO = new GenreDTO()
        {
            Id = genre.Id,
            Name = genre.Name,
        };

        return genreDTO;
    }

    public async Task<ICollection<GenreDTO>> GetGenresAsync()
    {
        var genres = await _genreRepository.SelectAllGenresAsync();

        var genresDTO = genres.Select(g => new GenreDTO { Id = g.Id, Name = g.Name }).ToList();

        return genresDTO;
    }

    public async Task<GenreDTO> PostGenreAsync(GenreCreateRequest genreCreateRequest)
    {
        if (genreCreateRequest == null)
            throw new ArgumentNullException(nameof(genreCreateRequest));

        var genreEntity = new Genre()
        {
            Name = genreCreateRequest.Genre.Name,
            ParentGenreId = genreCreateRequest.Genre.ParentGenreId,
        };

        genreEntity.Id = new Guid();

        var genreEntityFromDb = await _genreRepository.InsertGenreAsync(genreEntity);
        var genreDTO = new GenreDTO()
        {
            Id = genreEntity.Id,
            Name = genreEntity.Name,
        };

        return genreDTO;
    }

    public async Task PutGenreAsync(GenreUpdateRequest genreUpdateRequest)
    {
        if (genreUpdateRequest == null)
            throw new NullReferenceException(nameof(genreUpdateRequest));

        var genreEntity = await _genreRepository.SelectGenreByIdAsync(genreUpdateRequest.Genre.Id);

        if (genreEntity == null)
            throw new NotFoundException($"Genre with Id {genreUpdateRequest.Genre.Id} not found to update");

        genreEntity.Name = genreUpdateRequest.Genre.Name;
        genreEntity.ParentGenreId = genreUpdateRequest.Genre.ParentGenreId;

        await _genreRepository.UpdateGenreAsync(genreEntity);
        _genreRepository.SaveChanges();
    }
}
