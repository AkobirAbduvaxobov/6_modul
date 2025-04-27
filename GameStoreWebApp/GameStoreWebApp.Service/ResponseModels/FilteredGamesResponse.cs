using GameStoreWebApp.Service.DTOs.Game;

namespace GameStoreWebApp.Service.ResponseModels;

public class FilteredGamesResponse
{
    public List<GameDTO> FilteredGames { get; set; }
    public int? TotalPages { get; set; }
    public int? CurrentPage { get; set; }
}
