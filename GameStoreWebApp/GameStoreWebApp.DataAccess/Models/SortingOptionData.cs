using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class SortingOptionData
{
    public static List<SortingOption> GetPredefinedSortingOptions()
    {
        return new List<SortingOption>
        {
            new SortingOption { Id = Guid.NewGuid(), Option = "Most popular" },
            new SortingOption { Id = Guid.NewGuid(), Option = "Most commented" },
            new SortingOption { Id = Guid.NewGuid(), Option = "Price ASC" },
            new SortingOption { Id = Guid.NewGuid(), Option = "Price DESC" },
            new SortingOption { Id = Guid.NewGuid(), Option = "New" }
        };
    }
}
