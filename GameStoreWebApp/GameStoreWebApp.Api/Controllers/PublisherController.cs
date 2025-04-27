using GameStoreWebApp.Service.DTOs.Game;
using GameStoreWebApp.Service.DTOs.Publisher;
using GameStoreWebApp.Service.RequestModels;
using GameStoreWebApp.Service.Services.PublisherService;
using Microsoft.AspNetCore.Mvc;

namespace GameStoreWebApp.Api.Controllers;

[Route("publishers")]
[ApiController]
public class PublisherController : ControllerBase
{
    private readonly IPublisherService _publisherService;

    public PublisherController(IPublisherService publisherService)
    {
        _publisherService = publisherService;
    }

    [HttpPost]
    public async Task<PublisherDTO> PostPublisher(PublisherCreateRequest publisherCreateRequest)
    {
        var publisherDTO = await _publisherService.PostPublisherAsync(publisherCreateRequest);
        return publisherDTO;
    }

    [HttpGet("{companyName}")]
    public async Task<PublisherDTO> GetPublisherByCompanyName(string companyName)
    {
        var publisherDTO = await _publisherService.GetPublisherByCompanyNameAsync(companyName);
        return publisherDTO;
    }

    [HttpGet]
    public async Task<ICollection<PublisherDTO>> GetAllPublishers()
    {
        var publisherDTOs = await _publisherService.GetAllPublishersAsync();
        return publisherDTOs;
    }

    [HttpPut]
    public async Task PutPublisher(PublisherUpdateRequest publisherUpdateRequest)
    {
        await _publisherService.PutPublisherAsync(publisherUpdateRequest);
    }

    [HttpDelete("{id}")]
    public async Task DeletePublisherById(Guid id)
    {
        await _publisherService.DeletePublisherByIdAsync(id);
    }

    [HttpGet("{companyName}/games")]
    public async Task<ICollection<GameDTO>> GetAllGamesByCompanyName(string companyName)
    {
        var gamesDTO = await _publisherService.GetAllGamesByCompanyNameAsync(companyName);

        return gamesDTO;
    }
}
