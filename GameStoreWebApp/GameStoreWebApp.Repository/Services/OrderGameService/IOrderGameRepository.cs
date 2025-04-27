using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.OrderGameService;

public interface IOrderGameRepository
{
    Task<OrderGame> InsertOrderGameAsync(OrderGame orderGame);
    Task<OrderGame> SelectOrderGameByOrderIdAndProductIdAsync(Guid orderId, Guid gameId);
    Task UpdateOrderGameAsync(OrderGame orderGame);
    Task<ICollection<OrderGame>> GetOrderGamesByOrderIdAsync(Guid orderId);
    Task DeleteOrderGameAsync(OrderGame orderGame);
}
