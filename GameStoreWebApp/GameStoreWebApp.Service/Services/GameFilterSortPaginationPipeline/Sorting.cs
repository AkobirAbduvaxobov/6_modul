using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class Sorting : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        switch (request.Sort)
        {
            case "MostCommented":
                input = input.OrderByDescending(g => g.Comments.Count);
                break;
            case "PriceASC":
                input = input.OrderBy(g => g.Price);
                break;
            case "PriceDESC":
                input = input.OrderByDescending(g => g.Price);
                break;
            case "New":
                input = input.OrderByDescending(g => g.PublishedDate);
                break;
            default:
                break;
        }
        return input;
    }
}

