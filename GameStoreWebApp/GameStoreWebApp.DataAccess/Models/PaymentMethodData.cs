using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class PaymentMethodData
{
    public static List<PaymentMethod> GetPredefinedPaymentMethods()
    {
        return new List<PaymentMethod>
        {
            new PaymentMethod
            {
                Id = Guid.NewGuid(),
                ImageUrl = "Link1",
                Title = "Bank",
                Description = "Cool way1",
            },
            new PaymentMethod
            {
                Id = Guid.NewGuid(),
                ImageUrl = "Link2",
                Title = "IBox terminal",
                Description = "Cool way2",
            },
            new PaymentMethod
            {
                Id = Guid.NewGuid(),
                ImageUrl = "Link3",
                Title = "Visa",
                Description = "Cool way3",
            },
        };
    }
}
