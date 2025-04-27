using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class PublisherFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (request.Publisher != null)
        {
            input = input.Where(game => request.Publisher == game.PublisherId);
        }
        return input;
    }
}

