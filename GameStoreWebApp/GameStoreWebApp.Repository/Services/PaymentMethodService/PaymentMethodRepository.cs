using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.PaymentMethodService;

public class PaymentMethodRepository : IPaymentMethodRepository
{
    private MainContext _dbContext;

    public PaymentMethodRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<ICollection<PaymentMethod>> SelectAllPaymentMethodsAsync()
    {
        return _dbContext.PaymentMethods.ToList();
    }

    public async Task<bool> PaymentMethodExistsAsync(string title)
    {
        return await _dbContext.PaymentMethods
            .AnyAsync(pm => pm.Title == title);
    }
}
