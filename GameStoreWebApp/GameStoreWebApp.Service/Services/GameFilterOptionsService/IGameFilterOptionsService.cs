namespace GameStoreWebApp.Service.Services.GameFilterOptionsService;

public interface IGameFilterOptionsService
{
    Task<ICollection<string>> GetPaginationOptionsAsync();
    Task<ICollection<string>> GetSortingOptionsAsync();
    Task<ICollection<string>> GetPublishedDateFilterOptionsAsync();
}
