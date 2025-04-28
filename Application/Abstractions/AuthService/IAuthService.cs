using Application.DTOs.Auth;

namespace Application.Abstractions.AuthService
{
    public interface IAuthService
    {
        Task<LoginResponse> ValidateUserCredentialsAsync(string username, string password, CancellationToken ct=default);
        Task<LoginResponse> RefreshTokenAsync(string refreshToken, string userId, CancellationToken ct= default);
    }
}
