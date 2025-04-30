using System.Net;
using System.Text;
using System.Text.Json;
using Api.E2E.Tests.Models;
using Application.Abstractions.AuthService;
using Application.DTOs.Auth;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using Xunit;

namespace Api.E2E.Tests;

public class AuthEndpointTests : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _client;

    public AuthEndpointTests(CustomWebApplicationFactory factory)
    {
        _client = factory.CreateClient(new WebApplicationFactoryClientOptions
        {
            AllowAutoRedirect = false
        });
    }

    [Fact]
    public async Task Login_WithMockService_ShouldPass()
    {
        // Arrange
        var request = new LoginRequest
        {
            Username = "adminuser",
            Password = "password"
        };

        var requestJson = JsonSerializer.Serialize(request);
        var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

        // Act
        var response = await _client.PostAsync("/api/auth/login", content);

        // Assert
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        var responseContent = await response.Content.ReadAsStringAsync();
        Assert.NotNull(responseContent);
        Assert.NotEmpty(responseContent);

        // Verify that we got a JWT token back
        Assert.Contains("accessToken", responseContent.ToLower());
        Assert.Contains("user", responseContent.ToLower());
    }
} 