using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;

namespace GameStoreWebApp.Service.Services.PublisherService;

public interface IPublisherService
{
    Task<PublisherDTO> PostPublisherAsync(PublisherCreateRequest publisherCreateRequest);
    Task<ICollection<PublisherDTO>> GetAllPublishersAsync();
    Task<PublisherDTO> GetPublisherByCompanyNameAsync(string companyName);
    Task PutPublisherAsync(PublisherUpdateRequest publisherUpdateRequest);
    Task DeletePublisherByIdAsync(Guid id);
    Task<ICollection<GameDTO>> GetAllGamesByCompanyNameAsync(string companyName);
}