using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class GenreData
{
    public static List<Genre> GetPredefinedGenres()
    {
        var genres = new List<Genre>
        {
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Strategy",
                SubGenres = new List<Genre>
                {
                    new Genre { Id = Guid.NewGuid(), Name = "RTS" },
                    new Genre { Id = Guid.NewGuid(), Name = "TBS" }
                }
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "RPG"
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Sports"
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Races",
                SubGenres = new List<Genre>
                {
                    new Genre { Id = Guid.NewGuid(), Name = "Rally" },
                    new Genre { Id = Guid.NewGuid(), Name = "Arcade" },
                    new Genre { Id = Guid.NewGuid(), Name = "Formula" },
                    new Genre { Id = Guid.NewGuid(), Name = "Off-road" }
                }
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Action",
                SubGenres = new List<Genre>
                {
                    new Genre { Id = Guid.NewGuid(), Name = "FPS" },
                    new Genre { Id = Guid.NewGuid(), Name = "TPS" }
                }
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Adventure"
            },
            new Genre
            {
                Id = Guid.NewGuid(),
                Name = "Puzzle & Skill"
            }
        };

        foreach (var genre in genres)
        {
            if (genre.SubGenres != null && genre.SubGenres.Count > 0)
            {
                foreach (var subGenre in genre.SubGenres)
                {
                    subGenre.ParentGenreId = genre.Id;
                    subGenre.ParentGenre = genre;
                }
            }
        }

        return genres;
    }
}

