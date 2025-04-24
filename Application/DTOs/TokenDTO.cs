using System;

namespace Application.DTOs;

public class TokenDTO
{
    public string Token { get; set; }
    public DateTime Expiration { get; set; }
    public string RefreshToken { get; set; }
    public DateTime RefreshTokenExpiration { get; set; }
} 