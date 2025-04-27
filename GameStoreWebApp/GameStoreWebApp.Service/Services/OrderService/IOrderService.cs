using GameStoreWebApp.Service.DTOs.Order;

namespace GameStoreWebApp.Service.Services.OrderService;

public interface IOrderService
{
    Task AddGameToCartAsync(string key);
    Task DeleteGameFromCartAsync(string key);
    Task<ICollection<OrderDTO>> GetPaidCancelledOrdersAsync();
    Task<OrderDTO> GetOrderByIdAsync(Guid id);
    Task<ICollection<OrderDetailDTO>> GetOrderDetailsByOrderIdAsync(Guid id);
    Task<ICollection<OrderDetailDTO>> GetOpenOrderAsync();
}
