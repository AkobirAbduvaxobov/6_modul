using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public class PaginationOptionData
{
    public static List<PaginationOption> GetPredefinedPaginationOptions()
    {
        return new List<PaginationOption>
        {
            new PaginationOption { Id = Guid.NewGuid(), Option = "10" },
            new PaginationOption { Id = Guid.NewGuid(), Option = "20" },
            new PaginationOption { Id = Guid.NewGuid(), Option = "50" },
            new PaginationOption { Id = Guid.NewGuid(), Option = "100" },
            new PaginationOption { Id = Guid.NewGuid(), Option = "all" }
        };
    }
}
