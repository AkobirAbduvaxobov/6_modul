using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.PaymentMethodService;

public interface IPaymentMethodRepository
{
    Task<ICollection<PaymentMethod>> SelectAllPaymentMethodsAsync();
    Task<bool> PaymentMethodExistsAsync(string title);
}
