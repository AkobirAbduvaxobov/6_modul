namespace GameStoreWebApp.ExternalServiceBroker.Models;

public class VisaTransactionRequestDTO
{
    public double TransactionAmount { get; set; }
    public string CardHolderName { get; set; }
    public string CardNumber { get; set; }
    public int ExpirationMonth { get; set; }
    public int Cvv { get; set; }
    public int ExpirationYear { get; set; }
}
