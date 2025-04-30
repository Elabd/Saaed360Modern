using Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace Domain.Tests;

public class RefreshTokenTests
{
    [Fact]
    public void IsActive_ShouldReturnTrue_WhenNotRevokedAndNotExpired()
    {
        // Arrange
        var now = DateTime.UtcNow;
        var token = new RefreshToken
        {
            UserId = Guid.NewGuid(),
            Token = "RANDOM_TOKEN",
            ExpiresUtc = now.AddMinutes(10),
            CreatedUtc = now
        };

        // Act
        var active = token.IsActive;

        // Assert
        active.Should().BeTrue();
    }

    [Fact]
    public void IsActive_ShouldReturnFalse_WhenExpired()
    {
        var token = new RefreshToken
        {
            UserId = Guid.NewGuid(),
            Token = "RANDOM_TOKEN",
            ExpiresUtc = DateTime.UtcNow.AddMinutes(-1)
        };

        token.IsActive.Should().BeFalse();
    }

    [Fact]
    public void IsActive_ShouldReturnFalse_WhenRevoked()
    {
        var token = new RefreshToken
        {
            UserId = Guid.NewGuid(),
            Token = "RANDOM_TOKEN",
            ExpiresUtc = DateTime.UtcNow.AddMinutes(5),
            RevokedUtc = DateTime.UtcNow
        };

        token.IsActive.Should().BeFalse();
    }
}