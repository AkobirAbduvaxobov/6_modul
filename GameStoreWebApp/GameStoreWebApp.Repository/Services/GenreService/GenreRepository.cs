using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.GenreService;

public class GenreRepository : IGenreRepository
{
    private MainContext _dbContext;

    public GenreRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Genre> InsertGenreAsync(Genre genre)
    {
        var genreEntity = await _dbContext.Genres.AddAsync(genre);

        await _dbContext.SaveChangesAsync();    

        return genreEntity.Entity;
    }

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<ICollection<Genre>> SelectAllGenresAsync()
    {
        var genres = _dbContext.Genres.ToList();
        return genres;
    }

    public async Task<Genre> SelectGenreByIdAsync(Guid id)
    {
        return await _dbContext.Genres.FirstOrDefaultAsync(g => g.Id == id);
    }

    public async Task<ICollection<Game>> SelectGamesByGenreIdAsync(Guid id)
    {
        var query = _dbContext.Genres.Include(g => g.GameGenres)
                                        .ThenInclude(gg => gg.Game);

        var genre = await query.FirstOrDefaultAsync(ge => ge.Id == id);

        if(genre == null)
            throw new NotFoundException($"Genre with ID {id} was not found.");


        var games = genre.GameGenres.Select(gg => gg.Game).ToList();

        return games;
    }

    public async Task<ICollection<Genre>> SelectAllGenresByParentIdAsync(Guid id)
    {
        var genres = await _dbContext.Genres
            .Where(g => g.ParentGenreId == id)
            .ToListAsync();

        return genres;
    }

    public async Task UpdateGenreAsync(Genre genre)
    {
        if (_dbContext.Entry(genre).State != EntityState.Modified)
        {
            _dbContext.Genres.Update(genre);
        }
    }

    public async Task DeleteGenreAsync(Genre genre)
    {
        if (_dbContext.Entry(genre).State != EntityState.Deleted)
        {
            _dbContext.Genres.Remove(genre);
        }
    }
}
