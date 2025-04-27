using GameStoreWebApp.Service.DTOs.PaymentMethod;

namespace GameStoreWebApp.Service.RequestModels;

public class PaymentRequest
{
    public string Method { get; set; }
    public VisaCardDTO? Model { get; set; }
}
