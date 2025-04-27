namespace GameStoreWebApp.Repository.Services.GameCountService;

public interface IGameCountRepository
{
    Task<int> GetGameCountAsync();
}
