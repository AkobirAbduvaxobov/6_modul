using FluentValidation;
using GameStoreWebApp.Service.DTOs.Comment;

namespace GameStoreWebApp.Validators;

public class CommentCreateDTOValidator : AbstractValidator<CommentCreateDTO>
{
    public CommentCreateDTOValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Name is required.")
            .MinimumLength(2).WithMessage("Name length should be at least 2 characters.");

        RuleFor(x => x.Body)
            .NotEmpty().WithMessage("Body is required.");
    }
}
