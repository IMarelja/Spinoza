using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using MiddleWareSimulation.Models;
using MiddleWareSimulation.Services;

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
        public async Task<IActionResult> Login([FromBody] User loginUser)
        {
            User user = await _authService.LoginAsync(loginUser);
            if (user == null)
                return Unauthorized("Invalid credentials");

            return Ok(new { message = "Login successful", userId = user.ID });
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] User newUser)
        {
            User user = await _authService.RegisterAsync(newUser);
            if (user == null)
                return BadRequest("Username already exists");

            return Ok(new { message = "Registration successful", userId = user.ID });
        }
    }

}
