using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.OrderService;

public interface IOrderRepository
{
    Task<Order> InsertOrderAsync(Order order);
    Task<Order> SelectOpenOrderByCustomerIdAsync(Guid customerId);
    Task DeleteOrderAsync(Order order);
    Task<ICollection<Order>> SelectPaidCancelledOrdersAsync();
    Task<Order> SelectOrderByIdAsync(Guid id);
    Task<ICollection<OrderGame>> SelectOrderDetailsByOrderIdAsync(Guid id);
    Task<Order> SelectOpenOrderAsync();
    Task UpdateOrderStatusAsync(Order order);    
}
