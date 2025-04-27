using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class Pagination : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (request.Page.HasValue && request.PageCount.HasValue)
        {
            int skip = (request.Page.Value - 1) * request.PageCount.Value;
            return input.Skip(skip).Take(request.PageCount.Value);
        }

        return input;
    }
}

