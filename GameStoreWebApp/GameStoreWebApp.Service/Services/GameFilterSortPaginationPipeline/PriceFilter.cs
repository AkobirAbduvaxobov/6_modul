using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class PriceFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (request.MinPrice.HasValue)
        {
            input = input.Where(g => g.Price >= request.MinPrice.Value);
        }
        if (request.MaxPrice.HasValue)
        {
            input = input.Where(g => g.Price <= request.MaxPrice.Value);
        }
        return input;
    }
}

