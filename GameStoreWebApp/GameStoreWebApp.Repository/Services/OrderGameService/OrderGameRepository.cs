using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.OrderGameService;

public class OrderGameRepository : IOrderGameRepository
{
    private MainContext _dbContext;

    public OrderGameRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<OrderGame> InsertOrderGameAsync(OrderGame orderGame)
    {
        var orderGameEntity = await _dbContext.OrderGames.AddAsync(orderGame);

        await _dbContext.SaveChangesAsync();

        return orderGameEntity.Entity;
    }

    public async Task<OrderGame> SelectOrderGameByOrderIdAndProductIdAsync(Guid orderId, Guid gameId)
    {
        var orderGameEntity = await _dbContext.OrderGames
            .FirstOrDefaultAsync(og => og.OrderId == orderId && og.ProductId == gameId);

        return orderGameEntity;
    }

    public async Task UpdateOrderGameAsync(OrderGame orderGame)
    {
        if (_dbContext.Entry(orderGame).State != EntityState.Modified)
        {
            _dbContext.OrderGames.Update(orderGame);
        }

        await _dbContext.SaveChangesAsync();
    }

    public async Task<ICollection<OrderGame>> GetOrderGamesByOrderIdAsync(Guid orderId)
    {
        return await _dbContext.OrderGames
            .Where(og => og.OrderId == orderId)
            .ToListAsync();
    }

    public async Task DeleteOrderGameAsync(OrderGame orderGame)
    {
        if (_dbContext.Entry(orderGame).State != EntityState.Deleted)
        {
            _dbContext.OrderGames.Remove(orderGame);
        }
        await _dbContext.SaveChangesAsync();
    }
}
