using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MiddleWareSimulation.Services;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

public class AuthService : IAuthService
{
    private readonly string _connectionString;

    public AuthService(string context)
    {
        _connectionString = context;
    }

    public string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }
    }

    public async Task<User?> GetUserByUsernameAsync(string username)
    {
        User user = null;

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("GetUserByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", username);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new User
                            {
                                id = reader.GetInt32("ID"),
                                username = reader.GetString("Username"),
                                passwordHash = reader.GetString("Password")
                            };
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error retrieving user: {ex.Message}");
            throw;
        }

        return user;
    }


    public async Task<int> CreateUserAsync(User user)
    {
        int newUserId = 0;

        try
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("CreateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Input parameters
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.Parameters.AddWithValue("@Password", user.passwordHash);

                    // Output parameter
                    SqlParameter outputParam = new SqlParameter("@ID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    command.Parameters.Add(outputParam);

                    // Execute the procedure
                    command.ExecuteNonQuery();

                    // Get the output parameter value
                    newUserId = (int)outputParam.Value;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error creating user: {ex.Message}");
            throw;
        }

        return newUserId;
    }

    public async Task<bool> AuthenticateUserAsync(string username, string password)
    {
        try
        {
            User optionalUser = await GetUserByUsernameAsync(username);
            if (optionalUser != null)
            {
                User user = optionalUser;

                // Hash input password
                string hashedInput = HashPassword(password);

                // Convert stored password hash to char array for comparison
                string storedHash = user.passwordHash;

                // Compare the hashed passwords
                bool matches = hashedInput.SequenceEqual(storedHash);

                // Clean up sensitive data
                password = "0";
                hashedInput = "0";
                storedHash = "0";

                return matches;
            }

            // Clean up even if user not found
            password = "0";
            return false;
        }
        catch (Exception)
        {
            // Ensure cleanup even on exception
            password = "0";
            throw;
        }
    }
}
