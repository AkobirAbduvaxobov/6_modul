using GameStoreWebApp.DataAccess;
using GameStoreWebApp.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStoreWebApp.Repository.Services.PublisherService;

public class PublisherRepository : IPublisherRepository
{
    private MainContext _dbContext;

    public PublisherRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task RemovePublisherAsync(Publisher publisher)
    {
        if (_dbContext.Entry(publisher).State != EntityState.Deleted)
        {
            _dbContext.Publishers.Remove(publisher);
        }
    }

    public async Task<Publisher> InsertPublisherAsync(Publisher publisher)
    {
        var publisherEntity = await _dbContext.Publishers.AddAsync(publisher);
        await _dbContext.SaveChangesAsync();

        return publisherEntity.Entity;
    }

    public int SaveChanges()
    {
        return _dbContext.SaveChanges();
    }

    public async Task<ICollection<Publisher>> SelectAllPublisherAsync()
    {
        var publishers = _dbContext.Publishers.ToList();
        return publishers;
    }

    public async Task<Publisher> SelectPublisherByCompanyNameAsync(string companyName)
    {
        return await _dbContext.Publishers.FirstOrDefaultAsync(p => p.CompanyName == companyName);
    }

    public async Task<Publisher> SelectPublisherByIdAsync(Guid id)
    {
        var publisherEntity = await _dbContext.Publishers.FirstOrDefaultAsync(p => p.Id == id);

        return publisherEntity;
    }

    public async Task UpdatePublisherAsync(Publisher publisher)
    {
        if (_dbContext.Entry(publisher).State != EntityState.Modified)
        {
            _dbContext.Publishers.Update(publisher);
        }
    }

    public async Task<ICollection<Game>> SelectAllGamesByCompanyNameAsync(string companyName)
    {
        var publisher = await _dbContext.Publishers
                .Include(p => p.Games)
                .FirstOrDefaultAsync(p => p.CompanyName == companyName);

        return publisher?.Games.ToList() ?? new List<Game>();
    }
}
