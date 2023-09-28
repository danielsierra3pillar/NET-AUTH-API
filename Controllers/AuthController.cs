using Microsoft.AspNetCore.Mvc;
using AuthApi.DTO;
using AuthApi.Repositories;
using AuthApi.Models;

namespace AuthApi.Controllers;

// Controllers/AuthController.cs
[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public AuthController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto registerDto)
    {
        var user = new User
        {
            Email = registerDto.Email,
            Password = registerDto.Password // Use password hashing in real-world applications
        };

        await _userRepository.CreateUser(user);
        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        var user = await _userRepository.GetUserByEmail(loginDto.Email);

        if (user == null || user.Password != loginDto.Password) // Use password hashing in real-world applications
        {
            return Unauthorized();
        }

        return Ok();
    }
}
