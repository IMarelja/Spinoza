using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using MiddleWareSimulation.Moduls;
using MiddleWareSimulation.Services;
using Models;

namespace MiddleWareSimulation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] AuthLogin loginUser)
        {
            bool success = await _authService.AuthenticateUserAsync(loginUser.username, loginUser.password);
            if (!success)
                return Unauthorized("Invalid credentials");

            return Ok(new { message = "Login successful" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] AuthLogin newUser)
        {
            // Check if user already exists
            var existingUser = await _authService.GetUserByUsernameAsync(newUser.username);
            if (existingUser != null)
                return BadRequest("Username already exists");

            User newnewUser = new User
            {
                username = newUser.username,
                passwordHash = _authService.HashPassword(newUser.password)
            };

            int userId = await _authService.CreateUserAsync(newnewUser);
            return Ok(new { message = "Registration successful", userId });
        }
    }
}
