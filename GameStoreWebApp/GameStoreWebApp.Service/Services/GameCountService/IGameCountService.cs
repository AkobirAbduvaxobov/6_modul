namespace GameStoreWebApp.Service.Services.GameCountService;

public interface IGameCountService
{
    Task<int> GetGameCountAsync();  
}
