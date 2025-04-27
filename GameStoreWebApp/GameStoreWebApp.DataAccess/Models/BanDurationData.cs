using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class BanDurationData
{
    public static List<BanDuration> GetPredefinedBanDurations()
    {
        return new List<BanDuration>
        {
            new BanDuration { Id = Guid.NewGuid(), Duration = "1 hour" },
            new BanDuration { Id = Guid.NewGuid(), Duration = "1 day" },
            new BanDuration { Id = Guid.NewGuid(), Duration = "1 week" },
            new BanDuration { Id = Guid.NewGuid(), Duration = "1 month" },
            new BanDuration { Id = Guid.NewGuid(), Duration = "permanent" }
        };
    }
}
