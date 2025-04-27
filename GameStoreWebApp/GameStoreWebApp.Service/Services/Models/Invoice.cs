namespace GameStoreWebApp.Service.Services.Models;

public class Invoice
{
    public Guid UserId { get; set; }
    public Guid OrderId { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ValidityDate { get; set; }
    public double Sum { get; set; }
}
