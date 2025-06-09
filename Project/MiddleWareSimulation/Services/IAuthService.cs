using MiddleWareSimulation.Models;

namespace MiddleWareSimulation.Services
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(User loginUser);
        Task<User?> RegisterAsync(User newUser);
        char[] HashingPassword(string password);
    }
}
