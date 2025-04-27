namespace GameStoreWebApp.ExternalServiceBroker.Models;

public class IBoxResponse
{
    public Guid AccountNumber { get; set; }
    public Guid InvoiceNumber { get; set; }
    public int PaymentMethod { get; set; }
    public Guid AccountId { get; set; }
    public int Amount { get; set; }

}
