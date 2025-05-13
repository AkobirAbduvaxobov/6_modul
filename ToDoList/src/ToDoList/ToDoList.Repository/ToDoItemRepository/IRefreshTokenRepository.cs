using ToDoList.Dal.Entity;

namespace ToDoList.Repository.ToDoItemRepository;

public interface IRefreshTokenRepository
{
    Task AddRefreshToken(RefreshToken refreshToken);
    Task<RefreshToken> SelectRefreshToken(string refreshToken, long userId);
}