using GameStoreWebApp.ExternalServiceBroker.Models;

namespace GameStoreWebApp.ExternalServiceBroker.Brokers.Payment;

public interface IPaymentBroker
{
    Task<IBoxResponse> ProcessIBoxPaymentAsync(IBoxTransactionRequestDto iBoxRequest);
    Task ProcessVisaPaymentAsync(VisaTransactionRequestDTO visaTransactionRequest);
}
