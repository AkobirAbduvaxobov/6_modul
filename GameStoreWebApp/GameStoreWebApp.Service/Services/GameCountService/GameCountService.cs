
using GameStoreWebApp.Repository.Services.GameCountService;

namespace GameStoreWebApp.Service.Services.GameCountService;

public class GameCountService : IGameCountService
{
    private readonly IGameCountRepository _gameCountRepository;

    public GameCountService(IGameCountRepository gameCountRepository)
    {
        _gameCountRepository = gameCountRepository;
    }

    public async Task<int> GetGameCountAsync()
    {
        return await _gameCountRepository.GetGameCountAsync();  
    }
}
