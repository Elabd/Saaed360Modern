using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Application.Abstractions.AuthService;
using Application.DTOs.Auth;
using FluentAssertions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace Api.E2E.Tests;

public class MockAuthWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.UseEnvironment("Testing");
        
        builder.ConfigureTestServices(services =>
        {
            // Remove the real auth service
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType == typeof(IAuthService));
            
            if (descriptor != null)
            {
                services.Remove(descriptor);
            }
            
            // Create a mock auth service
            var mockAuthService = new Mock<IAuthService>();
            
            // Setup the mock to return a valid response for any login attempt
            var loginResponse = new LoginResponse
            {
                AccessToken = "mock-jwt-token",
                AccessTokenExpiration = DateTime.UtcNow.AddHours(1),
                User = new UserInfoDto
                {
                    UserId = Guid.NewGuid(),
                    UserName = "adminuser",
                    Email = "admin@example.com",
                    FullName = "Admin User"
                }
            };
            
            var refreshTokenDetails = new RefreshTokenDetails
            {
                Token = "mock-refresh-token",
                Expiration = DateTime.UtcNow.AddDays(7)
            };
            
            mockAuthService
                .Setup(m => m.ValidateUserCredentialsAsync(
                    It.IsAny<string>(), 
                    It.IsAny<string>(), 
                    It.IsAny<System.Threading.CancellationToken>()))
                .ReturnsAsync(new AuthResult(loginResponse, refreshTokenDetails));
                
            services.AddSingleton(mockAuthService.Object);
        });
    }
}

public class AuthEndpointTests : IClassFixture<MockAuthWebApplicationFactory>
{
    private readonly MockAuthWebApplicationFactory _factory;

    public AuthEndpointTests(MockAuthWebApplicationFactory factory) => _factory = factory;

    [Fact]
    public async Task Login_WithMockService_ShouldPass()
    {
        // Arrange
        var client = _factory.CreateClient();
        var content = new StringContent(
            JsonSerializer.Serialize(new { username = "adminuser", password = "password" }),
            Encoding.UTF8,
            "application/json");

        try
        {
            // Act
            var response = await client.PostAsync("/api/auth/login", content);

            // Assert
            response.EnsureSuccessStatusCode(); // This will throw if the status code is not a success code
            
            // Just verify the response came back
            var responseString = await response.Content.ReadAsStringAsync();
            responseString.Should().NotBeNullOrEmpty();
        }
        catch (Exception ex)
        {
            // If the test fails, there may be an inner exception with more details
            if (ex.InnerException != null)
            {
                // This is just a fallback to help debug - it will still fail the test
                throw new Exception($"Test failed with inner exception: {ex.InnerException.Message}", ex);
            }
            throw;
        }
    }
}
