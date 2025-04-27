using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class PublishedDateFilterOptionData
{
    public static List<PublishedDateFilterOption> GetPredefinedPublishedDateFilterOptions()
    {
        return new List<PublishedDateFilterOption>
        {
            new PublishedDateFilterOption { Id = Guid.NewGuid(), Option = "last week" },
            new PublishedDateFilterOption { Id = Guid.NewGuid(), Option = "last month" },
            new PublishedDateFilterOption { Id = Guid.NewGuid(), Option = "last year" },
            new PublishedDateFilterOption { Id = Guid.NewGuid(), Option = "2 years" },
            new PublishedDateFilterOption { Id = Guid.NewGuid(), Option = "3 years" }
        };
    }
}
