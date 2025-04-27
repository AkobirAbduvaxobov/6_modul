namespace GameStoreWebApp.DataAccess.Entities;

public class Ban
{
    public Guid Id { get; set; }
    public DateTime BannedUntil { get; set; }
    public Guid UserId { get; set; }
}
