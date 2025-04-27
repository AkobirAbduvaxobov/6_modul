using GameStoreWebApp.DataAccess;
using GameStoreWebApp.ExternalServiceBroker.Brokers.Payment;
using GameStoreWebApp.Repository.Services.CommentService;
using GameStoreWebApp.Repository.Services.ContentService;
using GameStoreWebApp.Repository.Services.GameCountService;
using GameStoreWebApp.Repository.Services.GameFilterOptionsService;
using GameStoreWebApp.Repository.Services.GameService;
using GameStoreWebApp.Repository.Services.GenreService;
using GameStoreWebApp.Repository.Services.OrderGameService;
using GameStoreWebApp.Repository.Services.OrderService;
using GameStoreWebApp.Repository.Services.PaymentMethodService;
using GameStoreWebApp.Repository.Services.PlatformService;
using GameStoreWebApp.Repository.Services.PublisherService;
using GameStoreWebApp.Service.Services.CommentService;
using GameStoreWebApp.Service.Services.ContentService;
using GameStoreWebApp.Service.Services.GameCountService;
using GameStoreWebApp.Service.Services.GameFilterOptionsService;
using GameStoreWebApp.Service.Services.GameService;
using GameStoreWebApp.Service.Services.GenreService;
using GameStoreWebApp.Service.Services.OrderService;
using GameStoreWebApp.Service.Services.PaymentService;
using GameStoreWebApp.Service.Services.PlatformService;
using GameStoreWebApp.Service.Services.PublisherService;

namespace GameStoreWebApp.Api.DependencyInjection;

public static class ServiceExtensions
{
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<MainContext>();

        services.AddTransient<IGameRepository, GameRepository>();
        services.AddTransient<IGameService, GameService>();

        services.AddTransient<IGenreRepository, GenreRepository>();
        services.AddTransient<IGenreService, GenreService>();

        services.AddTransient<IPlatformRepository, PlatformRepository>();
        services.AddTransient<IPlatformService, PlatformService>();

        services.AddTransient<IContentRepository, ContentRepository>();
        services.AddTransient<IContentService, ContentService>();

        services.AddTransient<IPublisherRepository, PublisherRepository>();
        services.AddTransient<IPublisherService, PublisherService>();

        services.AddTransient<IGameCountRepository, GameCountRepository>();
        services.AddTransient<IGameCountService, GameCountService>();

        services.AddTransient<IOrderGameRepository, OrderGameRepository>();
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient<IOrderService, OrderService>();

        services.AddTransient<IPaymentMethodRepository, PaymentMethodRepository>();
        services.AddTransient<IPaymentBroker, PaymentBroker>();
        services.AddTransient<IPaymentService, PaymentService>();
        services.AddHttpClient();

        services.AddTransient<ICommentRepository, CommentRepository>();
        services.AddTransient<ICommentService, CommentService>();

        services.AddTransient<IGameFilterOptionsRepository, GameFilterOptionsRepository>();
        services.AddTransient<IGameFilterOptionsService, GameFilterOptionsService>();
    }
}
