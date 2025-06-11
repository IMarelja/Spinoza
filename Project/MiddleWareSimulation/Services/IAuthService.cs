using Models;

namespace MiddleWareSimulation.Services
{
    public interface IAuthService
    {
        Task<User?> GetUserByUsernameAsync(string username);
        Task<int> CreateUserAsync(User user);
        Task<bool> AuthenticateUserAsync(string username, string password);
        string HashPassword(string password);
    }

}
