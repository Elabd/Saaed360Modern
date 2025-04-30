using System;
using System.Threading.Tasks;
using FluentAssertions;
using Infrastructure.Persistence;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace Infrastructure.Tests;

public class DbContextMappingTests : IDisposable
{
    private readonly ApplicationDbContext _ctx;

    public DbContextMappingTests()
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        _ctx = new ApplicationDbContext(options);
    }

    public void Dispose()
    {
        _ctx.Dispose();
    }

    [Fact]
    public async Task ActivityEntity_ShouldRoundtrip()
    {
        // Arrange
        var activity = new Domain.Entities.Activity
        {
            ActivityGuid = Guid.NewGuid(),
            SourceId = 1,
            ActivityCategoryId = 1,
            ActivityName = "Unit‑Test",
            CreateDateTimeStamp = DateTime.UtcNow,
            ModifiedDateTimeStamp = DateTime.UtcNow
        };

        // Act
        _ctx.Activities.Add(activity);
        await _ctx.SaveChangesAsync();

        // Assert
        var loaded = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        loaded.Should().NotBeNull();
        loaded.ActivityName.Should().Be("Unit‑Test");
        loaded.SourceId.Should().Be(1);
        loaded.ActivityCategoryId.Should().Be(1);
    }

    [Fact]
    public async Task ActivityEntity_ShouldHandleNullValues()
    {
        // Arrange
        var activity = new Domain.Entities.Activity
        {
            ActivityGuid = Guid.NewGuid(),
            SourceId = 1,
            ActivityCategoryId = 1,
            ActivityName = null,
            CreateDateTimeStamp = DateTime.UtcNow,
            ModifiedDateTimeStamp = DateTime.UtcNow
        };

        // Act
        _ctx.Activities.Add(activity);
        await _ctx.SaveChangesAsync();

        // Assert
        var loaded = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        loaded.Should().NotBeNull();
        loaded.ActivityName.Should().BeNull();
    }

    [Fact]
    public async Task ActivityEntity_ShouldHandleConcurrentUpdates()
    {
        // Arrange
        var activity = new Domain.Entities.Activity
        {
            ActivityGuid = Guid.NewGuid(),
            SourceId = 1,
            ActivityCategoryId = 1,
            ActivityName = "Original",
            CreateDateTimeStamp = DateTime.UtcNow,
            ModifiedDateTimeStamp = DateTime.UtcNow
        };

        _ctx.Activities.Add(activity);
        await _ctx.SaveChangesAsync();

        // Act
        var activity1 = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        var activity2 = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);

        activity1.ActivityName = "Updated1";
        activity2.ActivityName = "Updated2";

        await _ctx.SaveChangesAsync();

        // Assert
        var loaded = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        loaded.ActivityName.Should().Be("Updated2");
    }

    [Fact]
    public async Task ActivityEntity_ShouldTrackChanges()
    {
        // Arrange
        var activity = new Domain.Entities.Activity
        {
            ActivityGuid = Guid.NewGuid(),
            SourceId = 1,
            ActivityCategoryId = 1,
            ActivityName = "Original",
            CreateDateTimeStamp = DateTime.UtcNow,
            ModifiedDateTimeStamp = DateTime.UtcNow
        };

        _ctx.Activities.Add(activity);
        await _ctx.SaveChangesAsync();

        // Act
        var loaded = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        loaded.ActivityName = "Updated";
        await _ctx.SaveChangesAsync();

        // Assert
        var updated = await _ctx.Activities.FirstAsync(a => a.ActivityGuid == activity.ActivityGuid);
        updated.ActivityName.Should().Be("Updated");
    }
}