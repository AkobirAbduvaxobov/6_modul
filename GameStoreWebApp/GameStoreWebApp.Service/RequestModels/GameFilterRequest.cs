namespace GameStoreWebApp.Service.RequestModels;

public class GameFilterRequest
{
    public List<Guid> Genres { get; set; } = new List<Guid>();
    public List<Guid> Platforms { get; set; } = new List<Guid>();
    public Guid? Publisher { get; set; }
    public double? MinPrice { get; set; }
    public double? MaxPrice { get; set; }
    public string? Name { get; set; }
    public string? DatePublishing { get; set; }
    public string? Sort { get; set; }
    public int? Page { get; set; } 
    public int? PageCount { get; set; } 
    public string? Trigger { get; set; }
}
