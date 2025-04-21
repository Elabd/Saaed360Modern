using System;
using System.Threading.Tasks;
using Application.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var (isValid, userId) = await _authService.ValidateUserCredentials(request.Username, request.Password);

        if (!isValid)
        {
            return Unauthorized(new { message = "Invalid username or password" });
        }

        // For now, return a fake token
        // In a real system, you'd want to use JWT or similar
        var token = $"fake-token-{Guid.NewGuid()}";

        return Ok(new
        {
            token,
            userId
        });
    }
}

public class LoginRequest
{
    [Required]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }
} 