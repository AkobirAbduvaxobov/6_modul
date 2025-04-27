using FluentValidation;
using GameStoreWebApp.Repository.Services.GenreService;
using GameStoreWebApp.Service.DTOs.Genre;

public class GenreCreateDTOValidator : AbstractValidator<GenreCreateDTO>
{
    private readonly IGenreRepository _genreRepository;

    public GenreCreateDTOValidator(IGenreRepository genreRepository)
    {
        _genreRepository = genreRepository;

        RuleFor(x => x.Name)
            .MinimumLength(2).WithMessage("Genre name length should be minimum 2")
            .NotEmpty().WithMessage("Name is required.")
            .Must(IsUniqueName).WithMessage("Name must be unique.");

        RuleFor(x => x.ParentGenreId)
            .Must(IsValidParentGenreId).WithMessage("ParentGenreId must reference an existing genre.");
    }

    private bool IsUniqueName(string name)
    {
        var genres =  _genreRepository.SelectAllGenresAsync().Result;
        var res = !genres.Any(g => g.Name == name);

        return res;
    }

    private bool IsValidParentGenreId(Guid? parentGenreId)
    {
        if (!parentGenreId.HasValue)
        {
            return true;
        }
        var genres = _genreRepository.SelectAllGenresAsync().Result;
        var res = genres.Any(g => g.Id == parentGenreId.Value);

        return res;
    }
}
