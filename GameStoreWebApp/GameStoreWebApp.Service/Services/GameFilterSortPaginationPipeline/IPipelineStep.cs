using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.GameFilterSortPaginationPipeline;

public interface IPipelineStep<T>
{
    IQueryable<T> Process(IQueryable<T> input, GameFilterRequest request);
}
