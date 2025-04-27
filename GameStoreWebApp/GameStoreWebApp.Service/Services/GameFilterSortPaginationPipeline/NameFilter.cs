using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class NameFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (!string.IsNullOrEmpty(request.Name) && request.Name.Length >= 3)
        {
            input = input.Where(g => g.Name.Contains(request.Name));
        }
        return input;
    }
}

