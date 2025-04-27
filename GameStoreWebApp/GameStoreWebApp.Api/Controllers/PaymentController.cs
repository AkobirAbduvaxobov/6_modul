using GameStoreWebApp.Service.DTOs.PaymentMethod;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.PaymentService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }

    [HttpGet("orders/payment-methods")]
    public async Task<ICollection<PaymentMethodDTO>> GetPaymentMethods()
    {
        var paymentMethods = await _paymentService.GetAllPaymentMethodsAsync();
        return paymentMethods;
    }

    [HttpPost("orders/payment")]
    public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequest request)
    {
        if (request.Method == "Bank")
        {
            var invoicePdf = await _paymentService.BankPaymentAsync(request);

            return File(invoicePdf, "application/pdf", "invoice.pdf");
        }
        else if (request.Method == "IBox terminal")
        {
            var response = await _paymentService.IBoxPaymentAsync(request);
            return Ok(response);
        }
        else if (request.Method == "Visa")
        {
            await _paymentService.VisaPaymentAsync(request);
            return Ok();
        }

        return BadRequest();
    }
}
