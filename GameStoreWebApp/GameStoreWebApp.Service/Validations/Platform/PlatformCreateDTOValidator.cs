using FluentValidation;
using GameStoreWebApp.Service.DTOs.Platform;

public class PlatformCreateDTOValidator : AbstractValidator<PlatformCreateDTO>
{
    public PlatformCreateDTOValidator()
    {
        RuleFor(x => x.Type)
            .NotEmpty().WithMessage("Type is required.")
            .MinimumLength(2).WithMessage("Length should be minimum 1")
            .Must(IsValidType).WithMessage("There shouldnot be space");
    }

    private bool IsValidType(string type)
    {
        bool res = !type.Any(ch => ch == ' ');
        return res; 
    }
}
