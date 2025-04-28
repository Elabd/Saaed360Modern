// Application/Abstractions/IJwtFactory.cs
using Application.DTOs;
using System.Security.Claims;

namespace Application.Abstractions.AuthService;

public interface IJwtFactory
{
    /// <summary>Creates an access-token for the given user.</summary>
    string Create(Guid userId, string email, IEnumerable<Claim>? extraClaims = null);
    /// <summary>Optionally issues a new refresh-token too.</summary>
    (string AccessToken, string RefreshToken) CreateWithRefresh(
        Guid userId, string? email, IEnumerable<string>? roles = null);
}
