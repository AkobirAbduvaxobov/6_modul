using FluentValidation;
using GameStoreWebApp.Repository.Services.PublisherService;
using GameStoreWebApp.Service.DTOs.Publisher;

public class PublisherCreateDTOValidator : AbstractValidator<PublisherCreateDTO>
{
    private readonly IPublisherRepository _publisherRepository;
    public PublisherCreateDTOValidator(IPublisherRepository publisherRepository)
    {
        _publisherRepository = publisherRepository;

        RuleFor(x => x.CompanyName)
            .NotEmpty().WithMessage("Company name is required.")
            .MinimumLength(2).WithMessage("Company name's length should be minimum 2")
            .MaximumLength(100).WithMessage("Company name must be 100 characters or less.")
            .Must(IsUniqCompanyName).WithMessage("Company name should be unique");

        RuleFor(x => x.HomePage)
            .NotEmpty().WithMessage("Home page is required.");

        RuleFor(x => x.Description)
            .MaximumLength(500).WithMessage("Description must be 500 characters or less.");
    }

    private bool IsUniqCompanyName(string companyName)
    {
        var publisher = _publisherRepository.SelectPublisherByCompanyNameAsync(companyName).Result;

        if (publisher == null)
        {
            return true;
        }

        return false;
    }


}
