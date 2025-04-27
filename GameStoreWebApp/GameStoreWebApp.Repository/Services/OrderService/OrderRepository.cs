using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.DataAccess.Enums;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.OrderService;

public class OrderRepository : IOrderRepository
{
    private readonly MainContext _dbContext;

    public OrderRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Order> InsertOrderAsync(Order order)
    {
        var orderEntity = await _dbContext.Orders.AddAsync(order);
        await _dbContext.SaveChangesAsync();
        return orderEntity.Entity;
    }

    public async Task<Order> SelectOpenOrderByCustomerIdAsync(Guid customerId)
    {
        var orderEntity = await _dbContext.Orders
            .FirstOrDefaultAsync(o => o.CustomerId == customerId && o.Status == OrderStatus.Open);

        return orderEntity;
    }

    public async Task DeleteOrderAsync(Order order)
    {
        if (_dbContext.Entry(order).State != EntityState.Deleted)
        {
            _dbContext.Orders.Remove(order);
        }
        await _dbContext.SaveChangesAsync();
    }

    public async Task<ICollection<Order>> SelectPaidCancelledOrdersAsync()
    {
        var orders = await _dbContext.Orders
            .Where(or => or.Status == OrderStatus.Cancelled || or.Status == OrderStatus.Paid)
            .ToListAsync();

        return orders;
    }

    public async Task<Order> SelectOrderByIdAsync(Guid id)
    {
        var orderEntity = await _dbContext.Orders
            .FirstOrDefaultAsync(o => o.Id == id);

        return orderEntity;
    }

    public async Task<ICollection<OrderGame>> SelectOrderDetailsByOrderIdAsync(Guid id)
    {
        var orderGames = await _dbContext.OrderGames
            .Where(o => o.OrderId == id).ToListAsync();

        return orderGames;
    }

    public async Task<Order> SelectOpenOrderAsync()
    {
        var orderEntity = await _dbContext.Orders
         .FirstOrDefaultAsync(o => o.Status == OrderStatus.Open);

        return orderEntity;
    }

    public async Task UpdateOrderStatusAsync(Order order)
    {
        if (_dbContext.Entry(order).State != EntityState.Modified)
        {
            _dbContext.Orders.Update(order);
        }
        await _dbContext.SaveChangesAsync();
    }
}
