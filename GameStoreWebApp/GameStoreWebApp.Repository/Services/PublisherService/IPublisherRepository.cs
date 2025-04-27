using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.Repository.Services.PublisherService;

public interface IPublisherRepository
{
    Task<Publisher> InsertPublisherAsync(Publisher publisher);
    Task<Publisher> SelectPublisherByCompanyNameAsync(string companyName);
    Task<ICollection<Game>> SelectAllGamesByCompanyNameAsync(string companyName);
    Task<ICollection<Publisher>> SelectAllPublisherAsync();
    Task UpdatePublisherAsync(Publisher publisher);
    Task<Publisher> SelectPublisherByIdAsync(Guid id);
    Task RemovePublisherAsync(Publisher publisher);
    int SaveChanges();
}