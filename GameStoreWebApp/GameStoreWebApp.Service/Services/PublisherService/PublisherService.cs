using GamesStoreWebApp.Core.Errors;
using GameStoreWebApp.DataAccess.Entities;
using GameStoreWebApp.Repository.Services.PublisherService;
using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.PublisherService;

public class PublisherService : IPublisherService
{
    private readonly IPublisherRepository _publisherRepository;

    public PublisherService(IPublisherRepository publisherRepository)
    {
        _publisherRepository = publisherRepository;
    }

    public async Task<ICollection<PublisherDTO>> GetAllPublishersAsync()
    {
        var publishers = await _publisherRepository.SelectAllPublisherAsync();
        var publisherDTOs = publishers.Select(pu => ConvertToPublisherDTO(pu)).ToList();

        return publisherDTOs;
    }

    public async Task<PublisherDTO> GetPublisherByCompanyNameAsync(string companyName)
    {
        var publisherEntity = await _publisherRepository.SelectPublisherByCompanyNameAsync(companyName);

        if (publisherEntity == null)
            throw new NotFoundException($"Publisher with compamy {companyName} was not found.");

        var publisherDTO = ConvertToPublisherDTO(publisherEntity);

        return publisherDTO;
    }

    private PublisherDTO ConvertToPublisherDTO(Publisher publisher)
    {
        var publisherDTO = new PublisherDTO()
        {
            Id = publisher.Id,
            CompanyName = publisher.CompanyName,
            Description = publisher.Description,
            HomePage = publisher.HomePage,
        };

        return publisherDTO;
    }

    public async Task<PublisherDTO> PostPublisherAsync(PublisherCreateRequest publisherCreateRequest)
    {
        var publisherEntity = new Publisher()
        {
            Id = new Guid(),
            CompanyName = publisherCreateRequest.Publisher.CompanyName,
            HomePage = publisherCreateRequest.Publisher.HomePage,
            Description = publisherCreateRequest.Publisher.Description,
        };

        var publisherEntityFromDb = await _publisherRepository.InsertPublisherAsync(publisherEntity);

        var publisherDTO = new PublisherDTO()
        {
            Id = publisherEntityFromDb.Id,
            CompanyName = publisherEntityFromDb.CompanyName,
            Description = publisherEntityFromDb.Description,
            HomePage = publisherEntityFromDb.HomePage,
        };

        return publisherDTO;
    }

    public async Task PutPublisherAsync(PublisherUpdateRequest publisherUpdateRequest)
    {
        var publisherEntity = await _publisherRepository.SelectPublisherByIdAsync(publisherUpdateRequest.Publisher.Id);
        if (publisherEntity == null)
        {
            throw new NotFoundException($"Publisher with Id {publisherEntity.Id} not found to update");
        }

        publisherEntity.Description = publisherUpdateRequest.Publisher.Description;
        publisherEntity.CompanyName = publisherUpdateRequest.Publisher.CompanyName;
        publisherEntity.HomePage = publisherUpdateRequest.Publisher.HomePage;

        await _publisherRepository.UpdatePublisherAsync(publisherEntity);
        _publisherRepository.SaveChanges();
    }

    public async Task DeletePublisherByIdAsync(Guid id)
    {
        var publisherEntity = await _publisherRepository.SelectPublisherByIdAsync(id);

        if (publisherEntity == null)
        {
            throw new NotFoundException($"Publisher with Id {id} not found to delete");
        }

        await _publisherRepository.RemovePublisherAsync(publisherEntity);
        _publisherRepository.SaveChanges();
    }

    public async Task<ICollection<GameDTO>> GetAllGamesByCompanyNameAsync(string companyName)
    {
        var games = await _publisherRepository.SelectAllGamesByCompanyNameAsync(companyName);
        var gamesDTO = games.Select(g => new GameDTO
        {
            Id = g.Id,
            Name = g.Name,
            Description = g.Description,
            UnitInStock = g.UnitInStock,
            Discount = g.Discount,
            Key = g.Key,
            Price = g.Price
        }).ToList();

        return gamesDTO;
    }
}
