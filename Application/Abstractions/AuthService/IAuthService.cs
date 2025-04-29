using Application.DTOs.Auth;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Abstractions.AuthService
{
    /// <summary>
    /// Represents the combined result of an authentication operation,
    /// including the client-facing response and internal details for setting cookies.
    /// </summary>
    public record AuthResult(
        LoginResponse? ClientResponse, 
        RefreshTokenDetails? CookieDetails
    );

    public interface IAuthService
    {
        /// <summary>
        /// Validates user credentials and generates tokens.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>An AuthResult containing the client response and refresh token details for cookie setting, or null if validation fails.</returns>
        Task<AuthResult?> ValidateUserCredentialsAsync(string username, string password, CancellationToken ct = default);

        /// <summary>
        /// Refreshes an access token using a valid refresh token.
        /// </summary>
        /// <param name="refreshToken">The refresh token (typically from a cookie).</param>
        /// <param name="userId">The user ID associated with the token.</param>
        /// <param name="ct">Cancellation token.</param>
        /// <returns>An AuthResult containing the client response and new refresh token details for cookie setting, or null if refresh fails.</returns>
        Task<AuthResult?> RefreshTokenAsync(string refreshToken, string userId, CancellationToken ct = default);
    }
}

