using GameStoreWebApp.DataAccess.Configurations;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.DataAccess;

public class MainContext : DbContext
{

    public DbSet<Game> Games { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Platform> Platforms { get; set; }
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderGame> OrderGames { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<BanDuration> BanDurations { get; set; }
    public DbSet<Ban> Bans { get; set; }
    public DbSet<PaginationOption> PaginationOptions { get; set; }
    public DbSet<SortingOption> SortingOptions { get; set; }
    public DbSet<PublishedDateFilterOption> PublishedDateFilterOptions { get; set; }

    public MainContext(DbContextOptions<MainContext> options)
           : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new GameConfiguration());
        modelBuilder.ApplyConfiguration(new GenreConfiguration());
        modelBuilder.ApplyConfiguration(new PlatformConfiguration());
        modelBuilder.ApplyConfiguration(new GameGenreConfiguration());
        modelBuilder.ApplyConfiguration(new GamePlatformConfiguration());
        modelBuilder.ApplyConfiguration(new PublisherConfiguration());
        modelBuilder.ApplyConfiguration(new OrderConfiguration());
        modelBuilder.ApplyConfiguration(new OrderGameConfiguration());
        modelBuilder.ApplyConfiguration(new CommentConfiguration());
        modelBuilder.ApplyConfiguration(new BanConfiguration());

        SeedGenres(modelBuilder);
        SeedPlatforms(modelBuilder);
        SeedPaymentMethods(modelBuilder);
        SeedBanDurations(modelBuilder);
        SeedPaginationOptions(modelBuilder);
        SeedSortingOptions(modelBuilder);
        SeedPublishedDateFilterOptions(modelBuilder);
    }
    private void SeedPaginationOptions(ModelBuilder modelBuilder)
    {
        var predefinedPaginationOptions = PaginationOptionData.GetPredefinedPaginationOptions();

        foreach (var paginationOption in predefinedPaginationOptions)
        {
            modelBuilder.Entity<PaginationOption>().HasData(new
            {
                paginationOption.Id,
                paginationOption.Option
            });
        }
    }

    private void SeedSortingOptions(ModelBuilder modelBuilder)
    {
        var predefinedSortingOptions = SortingOptionData.GetPredefinedSortingOptions();

        foreach (var sortingOption in predefinedSortingOptions)
        {
            modelBuilder.Entity<SortingOption>().HasData(new
            {
                sortingOption.Id,
                sortingOption.Option
            });
        }
    }

    private void SeedPublishedDateFilterOptions(ModelBuilder modelBuilder)
    {
        var predefinedPublishedDateFilterOptions = PublishedDateFilterOptionData.GetPredefinedPublishedDateFilterOptions();

        foreach (var publishedDateFilterOption in predefinedPublishedDateFilterOptions)
        {
            modelBuilder.Entity<PublishedDateFilterOption>().HasData(new
            {
                publishedDateFilterOption.Id,
                publishedDateFilterOption.Option
            });
        }
    }
    private void SeedGenres(ModelBuilder modelBuilder)
    {
        var predefinedGenres = GenreData.GetPredefinedGenres();

        foreach (var genre in predefinedGenres)
        {
            modelBuilder.Entity<Genre>().HasData(new
            {
                genre.Id,
                genre.Name,
                ParentGenreId = genre.ParentGenreId
            });
        }

        foreach (var genre in predefinedGenres)
        {
            if (genre.SubGenres != null && genre.SubGenres.Count > 0)
            {
                foreach (var subGenre in genre.SubGenres)
                {
                    modelBuilder.Entity<Genre>().HasData(new
                    {
                        subGenre.Id,
                        subGenre.Name,
                        ParentGenreId = subGenre.ParentGenreId
                    });
                }
            }
        }
    }

    private void SeedPlatforms(ModelBuilder modelBuilder)
    {
        var predefinedPlatforms = PlatformData.GetPredefinedPlatforms();

        foreach (var platform in predefinedPlatforms)
        {
            modelBuilder.Entity<Platform>().HasData(new
            {
                platform.Id,
                platform.Type
            });
        }
    }


    private void SeedBanDurations(ModelBuilder modelBuilder)
    {
        var predefinedBanDurations = BanDurationData.GetPredefinedBanDurations();

        foreach (var banDuration in predefinedBanDurations)
        {
            modelBuilder.Entity<BanDuration>().HasData(new
            {
                banDuration.Id,
                banDuration.Duration
            });
        }
    }

    private void SeedPaymentMethods(ModelBuilder modelBuilder)
    {
        var predefinedPaymentMethods = PaymentMethodData.GetPredefinedPaymentMethods();

        foreach (var paymentMethod in predefinedPaymentMethods)
        {
            modelBuilder.Entity<PaymentMethod>().HasData(new
            {
                paymentMethod.Id,
                paymentMethod.ImageUrl,
                paymentMethod.Description,
                paymentMethod.Title,
            });
        }
    }


}
