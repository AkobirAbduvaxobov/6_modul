using GameStoreWebApp.Service.DTOs.PaymentMethod;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.ResponseModels;

namespace GameStoreWebApp.Service.Services.PaymentService;

public interface IPaymentService
{
    Task<ICollection<PaymentMethodDTO>> GetAllPaymentMethodsAsync();
    Task<byte[]> BankPaymentAsync(PaymentRequest paymentRequest);
    Task<IBoxResponseDTO> IBoxPaymentAsync(PaymentRequest paymentRequest);
    Task VisaPaymentAsync(PaymentRequest paymentRequest);
}
