using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class GenreFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (request.Genres != null && request.Genres.Any())
        {
            input = input.Where(game => game.GameGenres.Any(gg => request.Genres.Contains(gg.GenreId)));
        }
        return input;
    }
}
