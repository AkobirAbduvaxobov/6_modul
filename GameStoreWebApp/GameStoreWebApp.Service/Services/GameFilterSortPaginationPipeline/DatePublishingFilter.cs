using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class DatePublishingFilter : IPipelineStep<Game>
{
    public IQueryable<Game> Process(IQueryable<Game> input, GameFilterRequest request)
    {
        if (!string.IsNullOrEmpty(request.DatePublishing))
        {
            var dateRange = GetDateRange(request.DatePublishing);
            input = input.Where(g => g.PublishedDate >= dateRange);
        }
        return input;
    }

    private DateTime GetDateRange(string datePublishing)
    {
        return datePublishing switch
        {
            "lastWeek" => DateTime.Now.AddDays(-7),
            "lastMonth" => DateTime.Now.AddMonths(-1),
            "lastYear" => DateTime.Now.AddYears(-1),
            "last2Years" => DateTime.Now.AddYears(-2),
            "last3Years" => DateTime.Now.AddYears(-3),
            _ => DateTime.MinValue,
        };
    }
}

