using GameStoreWebApp.Service.Services.GameCountService;

public class TotalGamesCountMiddleware
{
    private readonly RequestDelegate _next;

    public TotalGamesCountMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IGameCountService gameCountService)
    {
        var totalGamesCount = await gameCountService.GetGameCountAsync();

        context.Response.OnStarting(() =>
        {
            context.Response.Headers.Add("x-total-numbers-of-games", totalGamesCount.ToString());
            return Task.CompletedTask;
        });

        await _next(context);
    }
}
