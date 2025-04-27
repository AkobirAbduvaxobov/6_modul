using GameStoreWebApp.Service.DTOs.Game;

namespace GameStoreWebApp.Service.RequestModels;

public class GameCreateRequest
{
    public GameCreateDTO Game { get; set; }
    public List<Guid> Genres { get; set; }
    public List<Guid> Platforms { get; set; }
    public Guid Publisher { get; set; }
}
