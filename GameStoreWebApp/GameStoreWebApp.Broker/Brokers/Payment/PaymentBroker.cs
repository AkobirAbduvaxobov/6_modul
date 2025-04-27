using GameStoreWebApp.ExternalServiceBroker.Helpers;
using GameStoreWebApp.ExternalServiceBroker.Models;
using System.Text;
using System.Text.Json;

namespace GameStoreWebApp.ExternalServiceBroker.Brokers.Payment;

public class PaymentBroker : IPaymentBroker
{
    private readonly HttpClient _httpClient;
    private const string baseUrl = "https://localhost:5001/api/payments";
    private static string iBoxPaymentUrl => $"{baseUrl}/ibox";
    private static string visaPaymentUrl => $"{baseUrl}/visa";
    private static int maxRetries = 3;
    private static TimeSpan retryDelay = TimeSpan.FromSeconds(2);


    public PaymentBroker(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IBoxResponse> ProcessIBoxPaymentAsync(IBoxTransactionRequestDto payment)
    {
        var res = await RetryHelper.RetryOnFailureAsync(async () =>
        {
            var json = JsonSerializer.Serialize(payment);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(iBoxPaymentUrl, content);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IBoxResponse>(responseBody);
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error processing payment: {response.StatusCode}, {errorResponse}");
            }
        }, maxRetries, retryDelay);

        return res;
    }


    public async Task ProcessVisaPaymentAsync(VisaTransactionRequestDTO visaTransactionRequest)
    {
        await RetryHelper.RetryOnFailureAsync(async () =>
        {
            var json = JsonSerializer.Serialize(visaTransactionRequest);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(visaPaymentUrl, content);

            if (response.IsSuccessStatusCode)
            {
                return;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Error processing payment: {response.StatusCode}, {errorResponse}");
            }
        }, maxRetries, retryDelay);
    }


}
