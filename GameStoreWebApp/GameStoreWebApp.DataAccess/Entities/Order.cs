using GameStoreWebApp.DataAccess.Enums;

namespace GameStoreWebApp.DataAccess.Entities;

public class Order
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public Guid CustomerId { get; set; }
    public OrderStatus Status { get; set; }

    public ICollection<OrderGame> OrderGames { get; set; } = new List<OrderGame>();
}

