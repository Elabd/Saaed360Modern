using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Infrastructure.Persistence.Contexts; // Adjust if your DbContext namespace is different
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Saaed360Modern.Application.Abstractions;
using Saaed360Modern.Application.Abstractions.AuthService; // Adjust if your interface namespace is different

namespace Infrastructure.Services.Auth // Adjust if your services namespace is different
{
    public class PermissionService : IPermissionService
    {
        private readonly IAppDbContext _db;
        private readonly IMemoryCache _cache;
        private readonly ILogger<PermissionService> _logger;
        // Define cache expiration (e.g., 10 minutes)
        private readonly MemoryCacheEntryOptions _cacheOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromMinutes(5)) // Example: Evict if not accessed for 5 mins
            .SetAbsoluteExpiration(TimeSpan.FromMinutes(15)); // Example: Force evict after 15 mins regardless

        // Cache key prefixes
        private const string OrgCachePrefix = "UserOrgs_";
        private const string AreaCachePrefix = "UserAreas_";
        private const string RoleCachePrefix = "UserRoles_";

        public PermissionService(IAppDbContext db, IMemoryCache cache, ILogger<PermissionService> logger)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
            _cache = cache ?? throw new ArgumentNullException(nameof(cache));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<long>> GetUserOrganizationIdsAsync(Guid userId, CancellationToken ct = default)
        {
            string cacheKey = $"{OrgCachePrefix}{userId}";
            if (!_cache.TryGetValue(cacheKey, out List<long> organizationIds))
            {
                _logger.LogDebug("Cache miss for organization IDs for UserId: {UserId}", userId);
                try
                {
                    // Fetch roles associated with the user
                    var roles = await _db.AspnetUsersInRoles
                        .Where(ur => ur.UserId == userId)
                        .Include(ur => ur.Role)
                            .ThenInclude(r => r.OrganizationRoles) // Include OrganizationRoles
                        .Select(ur => ur.Role)
                        .ToListAsync(ct);

                    // Extract distinct organization IDs from the roles
                    organizationIds = roles
                        .SelectMany(r => r.OrganizationRoles ?? new List<Domain.Entities.OrganizationRole>()) // Handle null OrganizationRoles
                        .Select(or => (long)or.OrganizationId)
                        .Distinct()
                        .ToList();

                    _cache.Set(cacheKey, organizationIds, _cacheOptions);
                    _logger.LogDebug("Cached {Count} organization IDs for UserId: {UserId}", organizationIds.Count, userId);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error fetching organization IDs for UserId: {UserId}", userId);
                    organizationIds = new List<long>(); // Return empty list on error
                }
            }
            else
            {
                _logger.LogDebug("Cache hit for organization IDs for UserId: {UserId}", userId);
            }
            return organizationIds ?? new List<long>();
        }

        public async Task<List<long>> GetUserAreaIdsAsync(Guid userId, CancellationToken ct = default)
        {
            string cacheKey = $"{AreaCachePrefix}{userId}";
            if (!_cache.TryGetValue(cacheKey, out List<long> areaIds))
            {
                _logger.LogDebug("Cache miss for area IDs for UserId: {UserId}", userId);
                try
                {
                    // Fetch PersonId first
                    var personId = await _db.PersonAspnetUsers
                                        .Where(pu => pu.UserId == userId)
                                        .Select(pu => (int?)pu.PersonId)
                                        .FirstOrDefaultAsync(ct);

                    if (personId.HasValue)
                    {                        
                        areaIds = await FetchAndCalculateAreasForPersonAsync(personId.Value, ct);
                    }
                    else
                    {
                        _logger.LogWarning("No Person found for UserId: {UserId} when fetching areas.", userId);
                        areaIds = new List<long>();
                    }

                    _cache.Set(cacheKey, areaIds, _cacheOptions);
                     _logger.LogDebug("Cached {Count} area IDs for UserId: {UserId}", areaIds.Count, userId);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error fetching area IDs for UserId: {UserId}", userId);
                    areaIds = new List<long>(); // Return empty list on error
                }
            }
            else
            {
                _logger.LogDebug("Cache hit for area IDs for UserId: {UserId}", userId);
            }
            return areaIds ?? new List<long>();
        }

        public async Task<List<string>> GetUserRolesAsync(Guid userId, CancellationToken ct = default)
        {
            string cacheKey = $"{RoleCachePrefix}{userId}";
            if (!_cache.TryGetValue(cacheKey, out List<string> roleNames))
            {
                _logger.LogDebug("Cache miss for role names for UserId: {UserId}", userId);
                try
                {
                    roleNames = await _db.AspnetUsersInRoles
                        .Where(ur => ur.UserId == userId)
                        .Include(ur => ur.Role) // Include Role to get the name
                        .Select(ur => ur.Role.RoleName) // Select the RoleName
                        .Where(rn => rn != null) // Ensure RoleName is not null
                        .ToListAsync(ct);

                    _cache.Set(cacheKey, roleNames, _cacheOptions);
                    _logger.LogDebug("Cached {Count} role names for UserId: {UserId}", roleNames.Count, userId);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error fetching role names for UserId: {UserId}", userId);
                    roleNames = new List<string>(); // Return empty list on error
                }
            }
            else
            {
                _logger.LogDebug("Cache hit for role names for UserId: {UserId}", userId);
            }
            return roleNames ?? new List<string>();
        }

        public void InvalidateUserCache(Guid userId)
        {
            _cache.Remove($"{OrgCachePrefix}{userId}");
            _cache.Remove($"{AreaCachePrefix}{userId}");
            _cache.Remove($"{RoleCachePrefix}{userId}");
            _logger.LogInformation("Invalidated permission cache for UserId: {UserId}", userId);
        }

        // --- Helper method to encapsulate area fetching logic --- 
        // IMPORTANT: This needs to replicate the logic from your original AuthService.ConvertToAreasAsync
        private async Task<List<long>> FetchAndCalculateAreasForPersonAsync(int personId, CancellationToken ct)
        {
            _logger.LogDebug("Fetching and calculating areas for PersonId: {PersonId}", personId);
            var finalAreaIds = new HashSet<long>();

            try
            {
                // 1. Get directly assigned areas
                var directAreas = await _db.PersonAreas
                                        .Where(pa => pa.PersonId == personId)
                                        .Select(pa => (long)pa.AreaId)
                                        .ToListAsync(ct);
                foreach (var areaId in directAreas) { finalAreaIds.Add(areaId); }
                _logger.LogDebug("Found {Count} direct areas for PersonId: {PersonId}", directAreas.Count, personId);

                // 2. Recursively find related areas (Adapt your existing logic here)
                // This is a simplified placeholder - replace with your actual recursive logic
                var currentLevelAreas = new List<long>(directAreas);
                var processedAreas = new HashSet<long>(directAreas);
                int iteration = 0;
                const int maxIterations = 10; // Safety break for recursion

                while (currentLevelAreas.Any() && iteration < maxIterations)
                {
                    iteration++;
                    _logger.LogDebug("Area fetching iteration {Iteration} for PersonId: {PersonId}, checking {Count} areas.", iteration, personId, currentLevelAreas.Count);
                    // Fix for CS1061: 'long' does not contain a definition for 'HasValue'
                    // The issue is that 'long' is a value type and cannot be null, so 'HasValue' is not applicable.
                    // The correct approach is to remove the 'HasValue' check and directly use the value.

                    var relatedAreas = await _db.AreaAssociations
                        .Where(aa => currentLevelAreas.Contains(aa.AreaId)) // Removed 'aa.RelatedAreaId.HasValue' as it is not valid for 'long'
                        .Select(aa => aa.RelatedAreaId) // Directly select the RelatedAreaId
                        .Distinct()
                        .ToListAsync(ct);

                    currentLevelAreas.Clear();
                    foreach (var relatedAreaId in relatedAreas)
                    {
                        if (processedAreas.Add(relatedAreaId)) // Add returns true if it was added (not already present)
                        {
                            finalAreaIds.Add(relatedAreaId);
                            currentLevelAreas.Add(relatedAreaId);
                        }
                    }
                     _logger.LogDebug("Found {Count} new related areas in iteration {Iteration} for PersonId: {PersonId}", currentLevelAreas.Count, iteration, personId);
                }
                if(iteration >= maxIterations)
                {
                    _logger.LogWarning("Max iterations reached during area calculation for PersonId: {PersonId}. Potential circular reference or deep hierarchy.", personId);
                }
            }
            catch (Exception ex)
            {
                 _logger.LogError(ex, "Error during recursive area calculation for PersonId: {PersonId}", personId);
                 // Depending on requirements, you might want to return partial results or throw
                 return new List<long>(); // Return empty on error for safety
            }

            _logger.LogInformation("Calculated {Count} total areas for PersonId: {PersonId}", finalAreaIds.Count, personId);
            return finalAreaIds.ToList();
        }
    }
}

