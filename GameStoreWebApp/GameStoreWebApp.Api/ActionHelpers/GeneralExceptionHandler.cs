using Microsoft.AspNetCore.Diagnostics;
using Serilog;

namespace GameStoreWebApp.Api.ActionHelpers;

public class GeneralExceptionHandler : IExceptionHandler
{
    private readonly ILogger<GeneralExceptionHandler> _logger;

    public GeneralExceptionHandler(ILogger<GeneralExceptionHandler> logger)
    {
        _logger = logger;
    }
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        _logger.LogError(exception, "Something went wrong..");
        Log.Error(exception, exception.Message);

        httpContext.Response.StatusCode = 501;
        await httpContext.Response.WriteAsync("Something went wrong..", cancellationToken);
        return true;
    }
}
