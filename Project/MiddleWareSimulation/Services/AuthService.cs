using Microsoft.EntityFrameworkCore;
using MiddleWareSimulation.Data;
using MiddleWareSimulation.Models;
using MiddleWareSimulation.Services;
using System.Security.Cryptography;
using System.Text;

namespace SpinozaAPI.Services
{
    public class AuthService : IAuthService
    {
        private readonly SpinozaDBContext _context;

        public AuthService(SpinozaDBContext context)
        {
            _context = context;
        }

        public char[] HashingPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes).ToCharArray();
            }
        }

        public async Task<User?> LoginAsync(User loginUser)
        {
            String hashedPassword = new string(HashingPassword(loginUser.Password));
            User user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginUser.Username && u.Password == hashedPassword);
            return user;
        }

        public async Task<User?> RegisterAsync(User newUser)
        {
            // Check if user already exists
            User existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == newUser.Username);

            if (existingUser != null)
                return null;

            String hashedPassword = new string(HashingPassword(newUser.Password));
            newUser.Password = hashedPassword;

            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            return newUser;
        }
    }
}