using Application.Abstractions.AuthService;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace Api.Controllers;

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
    public async Task<IActionResult> Login([FromBody] LoginRequest request)
    {
        var result = await _authService.ValidateUserCredentialsAsync(request.Username, request.Password);

        if (result==null)
        {
            return Unauthorized(new { message = "Invalid username or password" });
        }

        // Set refresh token cookie
        Response.Cookies.Append("refreshToken", result.CookieDetails.Token,
            new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = result.CookieDetails.Expiration
            });

        return Ok(result);
    }

    [HttpPost("refresh-token")]
    public async Task<IActionResult> RefreshToken()
    {
        try
        {
            // Get refresh token from cookie
            var refreshToken = Request.Cookies["refreshToken"];
            if (string.IsNullOrEmpty(refreshToken))
            {
                return Unauthorized(new { message = "Refresh token not found" });
            }

            // Get user ID from the expired token's claims
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized(new { message = "Invalid user ID" });
            }

            // Validate refresh token and get new tokens
            var result = await _authService.RefreshTokenAsync(refreshToken, userId);
            if (result==null)
            {
                return Unauthorized(new { message = "Invalid refresh token" });
            }

            // Set new refresh token cookie
            Response.Cookies.Append("refreshToken", result.CookieDetails.Token,
           new CookieOptions
           {
               HttpOnly = true,
               Secure = true,
               SameSite = SameSiteMode.Strict,
               Expires = result.CookieDetails.Expiration
           });

            return Ok(result);
        }
        catch (Exception ex)
        {
            // Log the exception
            return StatusCode(500, new { message = "An error occurred while refreshing the token" });
        }
    }
}

public class LoginRequest
{
    [Required]
    public required string Username { get; set; }

    [Required]
    public required string Password { get; set; }
} 