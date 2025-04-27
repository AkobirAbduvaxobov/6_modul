using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class PlatformFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (request.Platforms != null && request.Platforms.Any())
        {
            input = input.Where(game => game.GameGenres.Any(gg => request.Platforms.Contains(gg.GenreId)));
        }
        return input;
    }
}

