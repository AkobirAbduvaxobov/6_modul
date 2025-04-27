using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.DataAccess.Enums;
using GameStoreWebApp.Repository.Services.GameService;
using GameStoreWebApp.Repository.Services.OrderGameService;
using GameStoreWebApp.Repository.Services.OrderService;
using GameStoreWebApp.Repository.Services.PaymentMethodService;
using GameStoreWebApp.Service.DTOs.Order;


namespace GameStoreWebApp.Service.Services.OrderService;

public class OrderService : IOrderService
{
    private readonly IGameRepository _gameRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IOrderGameRepository _orderGameRepository;
    private readonly IPaymentMethodRepository _paymentMethodRepository;
    private const int validityDays = 30;

    public OrderService(IGameRepository gameRepository, IOrderRepository orderRepository, IOrderGameRepository orderGameRepository, IPaymentMethodRepository paymentMethodRepository)
    {
        _gameRepository = gameRepository;
        _orderRepository = orderRepository;
        _orderGameRepository = orderGameRepository;
        _paymentMethodRepository = paymentMethodRepository;
    }

    public async Task AddGameToCartAsync(string key)
    {
        var customerId = new Guid("00000000-0000-0000-0000-000000000000");
        var orderEntity = await _orderRepository.SelectOpenOrderByCustomerIdAsync(customerId);

        if (orderEntity == null)
        {
            orderEntity = new Order()
            {
                Id = Guid.NewGuid(),
                CustomerId = customerId,
                Date = DateTime.UtcNow,
                Status = OrderStatus.Open,
            };

            await _orderRepository.InsertOrderAsync(orderEntity);
        }

        var gameEntity = await _gameRepository.SelectGameByKeyAsync(key);
        if (gameEntity == null)
            throw new NotFoundException($"Game with key {key} was not found.");

        var existingOrderGame = await _orderGameRepository.SelectOrderGameByOrderIdAndProductIdAsync(orderEntity.Id, gameEntity.Id);

        if (existingOrderGame != null)
        {
            existingOrderGame.Quantity++;
            await _orderGameRepository.UpdateOrderGameAsync(existingOrderGame);
        }
        else
        {
            var orderGameEntity = new OrderGame()
            {
                OrderId = orderEntity.Id,
                ProductId = gameEntity.Id,
                Price = gameEntity.Price,
                Quantity = 1,
                Discount = gameEntity.Discount,
            };

            await _orderGameRepository.InsertOrderGameAsync(orderGameEntity);
        }
    }
    public async Task DeleteGameFromCartAsync(string key)
    {
        Guid customerId = new Guid("00000000-0000-0000-0000-000000000000");

        var openOrder = await _orderRepository.SelectOpenOrderByCustomerIdAsync(customerId);

        if (openOrder == null)
        {
            throw new NotFoundException("No open order found for the customer.");
        }

        var game = await _gameRepository.SelectGameByKeyAsync(key);
        if (game == null)
        {
            throw new NotFoundException($"Game with key {key} not found.");
        }

        var orderGame = await _orderGameRepository.SelectOrderGameByOrderIdAndProductIdAsync(openOrder.Id, game.Id);
        if (orderGame == null)
        {
            throw new NotFoundException($"Game with key {key} is not in the cart.");
        }

        if (orderGame.Quantity > 1)
        {
            orderGame.Quantity--;
            await _orderGameRepository.UpdateOrderGameAsync(orderGame);
        }
        else
        {
            await _orderGameRepository.DeleteOrderGameAsync(orderGame);
        }

        var remainingOrderGames = await _orderGameRepository.GetOrderGamesByOrderIdAsync(openOrder.Id);
        if (!remainingOrderGames.Any())
        {
            await _orderRepository.DeleteOrderAsync(openOrder);
        }
    }

    public async Task<OrderDTO> GetOrderByIdAsync(Guid id)
    {
        var orderEntity = await _orderRepository.SelectOrderByIdAsync(id);

        if (orderEntity is null)
        {
            throw new NotFoundException($"Order with id {id} is not found");
        }

        var orderDTO = new OrderDTO()
        {
            Id = orderEntity.Id,
            CustomerId = orderEntity.CustomerId,
            Date = orderEntity.Date,
        };

        return orderDTO;
    }

    public async Task<ICollection<OrderDetailDTO>> GetOrderDetailsByOrderIdAsync(Guid id)
    {
        var ordersDetailsEntity = await _orderRepository.SelectOrderDetailsByOrderIdAsync(id);

        var orderDetailsDTO = ordersDetailsEntity.Select(o => new OrderDetailDTO()
        {
            ProductId = o.ProductId,
            Price = o.Price,
            DisCount = o.Discount,
            Quantity = o.Quantity,
        }).ToList();

        return orderDetailsDTO;
    }

    public async Task<ICollection<OrderDTO>> GetPaidCancelledOrdersAsync()
    {
        var orders = await _orderRepository.SelectPaidCancelledOrdersAsync();

        var ordersDTO = orders.Select(order => new OrderDTO()
        {
            Id = order.Id,
            CustomerId = order.CustomerId,
            Date = order.Date,
        }).ToList();

        return ordersDTO;
    }
    public async Task<ICollection<OrderDetailDTO>> GetOpenOrderAsync()
    {
        var orderEntity = await _orderRepository.SelectOpenOrderAsync();
        if (orderEntity == null)
        {
            throw new NotFoundException($"Order is not found");
        }

        var orderDetailsEntity = await _orderRepository.SelectOrderDetailsByOrderIdAsync(orderEntity.Id);

        var orderDetailsDTO = orderDetailsEntity.Select(o => new OrderDetailDTO()
        {
            ProductId = o.ProductId,
            Price = o.Price,
            Quantity = o.Quantity,
            DisCount = o.Discount,
        }).ToList();

        return orderDetailsDTO;
    }
}
