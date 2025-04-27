using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.DataAccess.Enums;
using GameStoreWebApp.ExternalServiceBroker.Brokers.Payment;
using GameStoreWebApp.ExternalServiceBroker.Models;
using GameStoreWebApp.Repository.Services.OrderService;
using GameStoreWebApp.Repository.Services.PaymentMethodService;
using GameStoreWebApp.Service.DTOs.PaymentMethod;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.ResponseModels;
using GameStoreWebApp.Service.Services.Models;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;

namespace GameStoreWebApp.Service.Services.PaymentService;

public class PaymentService : IPaymentService
{
    private readonly IPaymentMethodRepository _paymentMethodRepository;
    private readonly IOrderRepository _orderRepository;
    private readonly IPaymentBroker _paymentBroker;
    private const int validityDays = 30;

    public PaymentService(IPaymentMethodRepository paymentMethodRepository, IOrderRepository orderRepository, IPaymentBroker paymentBroker)
    {
        _paymentMethodRepository = paymentMethodRepository;
        _orderRepository = orderRepository;
        _paymentBroker = paymentBroker;
    }

    public async Task<ICollection<PaymentMethodDTO>> GetAllPaymentMethodsAsync()
    {
        var paymentMethods = await _paymentMethodRepository.SelectAllPaymentMethodsAsync();

        var paymentMethodsDTO = paymentMethods.Select(p => new PaymentMethodDTO()
        {
            Description = p.Description,
            Title = p.Title,
            ImageUrl = p.ImageUrl,
        }).ToList();

        return paymentMethodsDTO;
    }

    public async Task<IBoxResponseDTO> IBoxPaymentAsync(PaymentRequest paymentRequest)
    {
        var isPaymentMethodExists = await _paymentMethodRepository.PaymentMethodExistsAsync(paymentRequest.Method);
        if (isPaymentMethodExists is false)
        {
            throw new NotFoundException($"Payment method with title {paymentRequest.Method} was not found.");
        }

        var orderEntity = await _orderRepository.SelectOpenOrderAsync();
        if (orderEntity == null)
        {
            throw new NotFoundException($"Order is not found");
        }

        var orderDetailsEntity = await _orderRepository.SelectOrderDetailsByOrderIdAsync(orderEntity.Id);
        var orderDetails = orderDetailsEntity.ToList();

        var iBoxRequest = new IBoxTransactionRequestDto()
        {
            AccountNumber = orderEntity.Id,
            InvoiceNumber = orderEntity.Id,
            TransactionAmount = 0
        };

        var iBoxResponse = await _paymentBroker.ProcessIBoxPaymentAsync(iBoxRequest);

        var iBoxResponseDTO = new IBoxResponseDTO()
        {
            UserId = iBoxResponse.AccountId,
            OrderId = iBoxResponse.InvoiceNumber,
            PaymentDate = DateTime.Now,
            Sum = getTotalPrice(orderDetails)
        };

        orderEntity.Status = OrderStatus.Paid;
        await _orderRepository.UpdateOrderStatusAsync(orderEntity);

        return iBoxResponseDTO;
    }

    public async Task VisaPaymentAsync(PaymentRequest paymentRequest)
    {
        var isPaymentMethodExists = await _paymentMethodRepository.PaymentMethodExistsAsync(paymentRequest.Method);
        if (isPaymentMethodExists is false)
        {
            throw new NotFoundException($"Payment method with title {paymentRequest.Method} was not found.");
        }

        var orderEntity = await _orderRepository.SelectOpenOrderAsync();
        if (orderEntity == null)
        {
            throw new NotFoundException($"Order is not found");
        }

        var orderDetailsEntity = await _orderRepository.SelectOrderDetailsByOrderIdAsync(orderEntity.Id);
        var orderDetails = orderDetailsEntity.ToList();

        var visaRequest = new VisaTransactionRequestDTO()
        {
            TransactionAmount = 0,
            CardHolderName = paymentRequest.Model.Holder,
            CardNumber = paymentRequest.Model.CardNumber,
            ExpirationMonth = paymentRequest.Model.MonthExpire,
            ExpirationYear = paymentRequest.Model.YearExpire,
            Cvv = paymentRequest.Model.Cvv2
        };

        await _paymentBroker.ProcessVisaPaymentAsync(visaRequest);

        orderEntity.Status = OrderStatus.Paid;
        await _orderRepository.UpdateOrderStatusAsync(orderEntity);
    }

    public async Task<byte[]> BankPaymentAsync(PaymentRequest paymentRequest)
    {
        var isPaymentMethodExists = await _paymentMethodRepository.PaymentMethodExistsAsync(paymentRequest.Method);
        if (isPaymentMethodExists is false)
        {
            throw new NotFoundException($"Payment method with title {paymentRequest.Method} was not found.");
        }

        var orderEntity = await _orderRepository.SelectOpenOrderAsync();
        if (orderEntity == null)
        {
            throw new NotFoundException($"Order is not found");
        }

        var orderDetailsEntity = await _orderRepository.SelectOrderDetailsByOrderIdAsync(orderEntity.Id);
        var orderDetails = orderDetailsEntity.ToList();

        var invoice = new Invoice
        {
            UserId = orderEntity.CustomerId,
            OrderId = orderEntity.Id,
            CreationDate = DateTime.UtcNow,
            ValidityDate = DateTime.UtcNow.AddDays(validityDays),
            Sum = getTotalPrice(orderDetails)
        };

        orderEntity.Status = OrderStatus.Paid;
        await _orderRepository.UpdateOrderStatusAsync(orderEntity);

        return GeneratePdf(invoice);
    }

    private byte[] GeneratePdf(Invoice invoice)
    {
        QuestPDF.Settings.License = LicenseType.Community;

        using (var memoryStream = new MemoryStream())
        {
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(20);
                            x.Item().Text($"User ID: {invoice.UserId}");
                            x.Item().Text($"Order ID: {invoice.OrderId}");
                            x.Item().Text($"Creation Date: {invoice.CreationDate:yyyy-MM-dd}");
                            x.Item().Text($"Validity Date: {invoice.ValidityDate:yyyy-MM-dd}");
                            x.Item().Text($"Sum: {invoice.Sum:C}");
                        });
                });
            })
            .GeneratePdf(memoryStream);

            return memoryStream.ToArray();
        }
    }

    private double getTotalPrice(List<OrderGame> orderDetails)
    {
        double totalPrice = 0;

        foreach (var orderGame in orderDetails)
        {
            double discountedPrice = orderGame.Price * (1 - (orderGame.Discount / 100.0));
            totalPrice += discountedPrice * orderGame.Quantity;
        }

        return totalPrice;
    }

    
}
