using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.GenreService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class GenreController : ControllerBase
{
    private readonly IGenreService _genreService;

    public GenreController(IGenreService genreService)
    {
        _genreService = genreService;
    }

    [HttpGet("genres/{id}/games")]
    public Task<ICollection<GameDTO>> GetGamesByGenreId(Guid id)
    {
        var gamesDTO = _genreService.GetGamesByGenreIdAsync(id);
        return gamesDTO;
    }

    [HttpPost("genres")]
    public async Task<GenreDTO> PostGenre(GenreCreateRequest genreCreateRequest)
    {
        var genreDTO = await _genreService.PostGenreAsync(genreCreateRequest);
        return genreDTO;
    }

    [HttpGet("genres/{id}")]
    public async Task<GenreDTO> GetGenreById(Guid id)
    {
        return await _genreService.GetGenreByIdAsync(id);
    }

    [HttpGet("genres")]
    public async Task<ICollection<GenreDTO>> GetGenres()
    {
        return await _genreService.GetGenresAsync();
    }

    [HttpGet("genres/{id}/genres")]
    public async Task<ICollection<GenreDTO>> GetGenresByParentId(Guid id)
    {
        return await _genreService.GetAllGenresByParentIdAsync(id);
    }

    [HttpPut("genres")]
    public async Task PutGenre(GenreUpdateRequest genreUpdateRequest)
    {
        await _genreService.PutGenreAsync(genreUpdateRequest);
    }

    [HttpDelete("genres/{id}")]
    public async Task DeleteGenreById(Guid id)
    {
        await _genreService.DeleteGenreByIdAsync(id);
    }
}
