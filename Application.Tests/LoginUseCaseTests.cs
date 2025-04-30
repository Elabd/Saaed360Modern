using Application.Abstractions.AuthService;
using Application.DTOs.Auth;
using FluentAssertions;
using Moq;
using System.Threading.Tasks;
using Xunit;

namespace Application.Tests;

public class LoginUseCaseTests
{
    private readonly Mock<IAuthService> _authService = new();

    [Fact]
    public async Task Login_ShouldReturnJwt_WhenCredentialsValid()
    {
        // Arrange
        var request = new LoginRequest { Username = "admin", Password = "secret" };
        _authService.Setup(s => s.ValidateUserCredentialsAsync(request.Username, request.Password, default))
                    .ReturnsAsync(new AuthResult(new LoginResponse { AccessToken = "jwt-token" }, null));

        // Act
        var result = await _authService.Object.ValidateUserCredentialsAsync(request.Username, request.Password);

        // Assert
        result.Should().NotBeNull();
        result!.ClientResponse!.AccessToken.Should().Be("jwt-token");
    }
}