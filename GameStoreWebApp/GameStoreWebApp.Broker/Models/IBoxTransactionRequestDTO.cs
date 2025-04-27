namespace GameStoreWebApp.ExternalServiceBroker.Models;

public class IBoxTransactionRequestDto
{
    public double TransactionAmount { get; set; }
    public Guid AccountNumber { get; set; }
    public Guid InvoiceNumber { get; set; }
}
