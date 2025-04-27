using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public class GamePipeline
{
    private readonly List<IPipelineStep<Game>> _steps;

    public GamePipeline()
    {
        _steps = new List<IPipelineStep<Game>>();
    }

    public GamePipeline AddStep(IPipelineStep<Game> step)
    {
        _steps.Add(step);
        return this;
    }

    public IQueryable<Game> Execute(IQueryable<Game> games, GameFilterRequest request)
    {
        return _steps.Aggregate(games, (current, step) => step.Process(current, request));
    }
}

