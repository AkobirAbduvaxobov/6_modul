namespace GameStoreWebApp.Service.DTOs.Order;

public class OrderDetailDTO
{
    public Guid ProductId { get; set; }
    public Double Price { get; set; }
    public int Quantity { get; set; }
    public int DisCount { get; set; }
}
