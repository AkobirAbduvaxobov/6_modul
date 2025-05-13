using Microsoft.EntityFrameworkCore;
using ToDoList.Dal;
using ToDoList.Dal.Entity;

namespace ToDoList.Repository.ToDoItemRepository;

public class RefreshTokenRepository : IRefreshTokenRepository
{

    private readonly MainContext MainContext;

    public RefreshTokenRepository(MainContext mainDbContext)
    {
        MainContext = mainDbContext;
    }

    public async Task AddRefreshToken(RefreshToken refreshToken)
    {
        await MainContext.RefreshTokens.AddAsync(refreshToken);
        await MainContext.SaveChangesAsync();
    }

    public async Task<RefreshToken> SelectRefreshToken(string refreshToken, long userId)
    {
        return await MainContext.RefreshTokens.FirstOrDefaultAsync(rt => rt.Token == refreshToken && rt.UserId == userId);
    }
}
