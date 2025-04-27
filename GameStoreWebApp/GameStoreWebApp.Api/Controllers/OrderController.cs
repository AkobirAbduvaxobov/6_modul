using GameStoreWebApp.Service.DTOs.Order;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;

    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    [HttpPost("games/{key}/buy")]
    public async Task<IActionResult> AddGameToCart(string key)
    {
        await _orderService.AddGameToCartAsync(key);
        return Ok();
    }

    [HttpDelete("orders/cart/{key}")]
    public async Task<IActionResult> DeleteGameFromCart(string key)
    {
        await _orderService.DeleteGameFromCartAsync(key);
        return Ok();
    }

    [HttpGet("orders")]
    public async Task<ICollection<OrderDTO>> GetPaidCancelledOrders()
    {
        var ordersDTO = await _orderService.GetPaidCancelledOrdersAsync();

        return ordersDTO;
    }

    [HttpGet("orders/{id}")]
    public async Task<OrderDTO> GetOrderById(Guid id)
    {
        var orderDTO = await _orderService.GetOrderByIdAsync(id);
        return orderDTO;
    }

    [HttpGet("orders/{id}/details")]
    public async Task<ICollection<OrderDetailDTO>> GetOrderDetails(Guid id)
    {
        var orderDetails = await _orderService.GetOrderDetailsByOrderIdAsync(id);
        return orderDetails;
    }

    [HttpGet("orders/cart")]
    public async Task<ICollection<OrderDetailDTO>> GetCart()
    {
        var res = await _orderService.GetOpenOrderAsync();
        return res;
    }
}
