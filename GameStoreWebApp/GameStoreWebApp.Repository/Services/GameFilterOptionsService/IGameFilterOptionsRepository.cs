using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.GameFilterOptionsService;

public interface IGameFilterOptionsRepository
{
    Task<ICollection<PaginationOption>> SelectPaginationOptionsAsync();
    Task<ICollection<SortingOption>> SelectSortingOptionsAsync();
    Task<ICollection<PublishedDateFilterOption>> SelectPublishedDateFilterOptionsAsync();
}
