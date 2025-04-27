using GamesStoreWebApp.Core.Errors;
using Microsoft.AspNetCore.Diagnostics;
using Serilog;

namespace GameStoreWebApp.Api.ActionHelpers;

public class AppExceptionHandler : IExceptionHandler
{
    private readonly ILogger<AppExceptionHandler> _logger;

    public AppExceptionHandler(ILogger<AppExceptionHandler> logger)
    {
        _logger = logger;
    }
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        (int statusCode, string errorMessage) = exception switch
        {
            NullReferenceException nullReferenceException => (400, nullReferenceException.Message),
            ArgumentException argumentException => (400, argumentException.Message),
            NotFoundException notFoundException => (404, notFoundException.Message),
            _ => default
        };

        if (statusCode == default)
        {
            return false;
        }
        _logger.LogError(exception, exception.Message);
        Log.Error(exception, exception.Message);
        httpContext.Response.StatusCode = statusCode;
        await httpContext.Response.WriteAsJsonAsync(errorMessage);

        return true;
    }
}
