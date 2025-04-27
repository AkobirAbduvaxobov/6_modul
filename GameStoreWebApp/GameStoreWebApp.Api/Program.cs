using FluentValidation.AspNetCore;
using GameStoreWebApp.Api.ActionHelpers;
using GameStoreWebApp.Api.Configurations;
using GameStoreWebApp.Api.DependencyInjection;
using GameStoreWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using System.Reflection;

namespace GameStoreWebApp.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(builder.Configuration).CreateLogger();

        // Add services to the container.
        builder.Services.AddControllers().AddFluentValidation();

        // Add Swagger services
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Version = "v1",
                Title = "GameStore Web API",
                Description = "An ASP.NET Core Web API for managing game store items",
                TermsOfService = new Uri("https://gamestore.example.com/terms"),
                Contact = new OpenApiContact
                {
                    Name = "GameStore Support",
                    Url = new Uri("https://gamestore.example.com/contact"),
                    Email = "support@gamestore.example.com"
                },
                License = new OpenApiLicense
                {
                    Name = "Use under XYZ License",
                    Url = new Uri("https://gamestore.example.com/license")
                }
            });

            // Set the comments path for the Swagger JSON and UI.
            var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
            var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
            options.IncludeXmlComments(xmlPath);
        });



        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder =>
                {
                    builder.WithOrigins("http://172.23.192.1:8080", "http://172.29.96.1:8080", "http://172.26.48.1:8080",
                                        "http://172.17.112.1:8080", "http://172.18.64.1:8080", "http://172.17.208.1:8080") // Corrected the typo
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });
        // http://172.18.64.1:8080


        builder.Services.RegisterServices();
        builder.Services.AddValidations();

        var connectionString = builder.Configuration["ConnectionStrings:SqlConnectionString"];
        builder.Services.AddDbContext<MainContext>(options =>
            options.UseSqlServer(connectionString)
        );

        builder.Services.AddExceptionHandler<AppExceptionHandler>();
        builder.Services.AddExceptionHandler<GeneralExceptionHandler>();

        var app = builder.Build();

        app.UseExceptionHandler(_ => { });

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "GameStore Web API v1");
            });
        }

        app.UseHttpsRedirection();

        app.UseCors("AllowSpecificOrigin"); // Ensure this is included before UseAuthorization

        app.UseAuthorization();

        app.UseMiddleware<TotalGamesCountMiddleware>();

        app.MapControllers();

        app.Run();
    }
}
