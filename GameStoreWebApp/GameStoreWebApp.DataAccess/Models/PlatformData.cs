using GameStoreWebApp.DataAccess.Entities;

namespace GameStoreWebApp.DataAccess.Models;

public static class PlatformData
{
    public static List<Platform> GetPredefinedPlatforms()
    {
        return new List<Platform>
        {
            new Platform { Id = Guid.NewGuid(), Type = "Mobile" },
            new Platform { Id = Guid.NewGuid(), Type = "Browser" },
            new Platform { Id = Guid.NewGuid(), Type = "Desktop" },
            new Platform { Id = Guid.NewGuid(), Type = "Console" }
        };
    }
}

