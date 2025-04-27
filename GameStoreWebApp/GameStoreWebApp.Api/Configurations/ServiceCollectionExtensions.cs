using FluentValidation;
using FluentValidation.AspNetCore;
using GameStoreWebApp.Service.DTOs.Comment;
using GameStoreWebApp.Service.DTOs.Genre;
using GameStoreWebApp.Service.DTOs.Platform;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Validators;
using System.Reflection;

namespace GameStoreWebApp.Api.Configurations;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddValidations(this IServiceCollection services)
    {
        services.AddTransient<IValidator<PlatformCreateDTO>, PlatformCreateDTOValidator>();
        services.AddTransient<IValidator<PlatformUpdateDTO>, PlatformUpdateDTOValidator>();

        services.AddTransient<IValidator<GenreCreateDTO>, GenreCreateDTOValidator>();
        services.AddTransient<IValidator<GenreUpdateDTO>, GenreUpdateDTOValidator>();

        services.AddTransient<IValidator<PublisherCreateDTO>, PublisherCreateDTOValidator>();
        services.AddTransient<IValidator<PublisherDTO>, PublisherDTOValidator>();

        services.AddTransient<IValidator<CommentCreateDTO>, CommentCreateDTOValidator>();

        return services;
    }
}
