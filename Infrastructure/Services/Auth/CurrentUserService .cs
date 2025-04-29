using Application.Abstractions;
using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Saaed360Modern.Application.Abstractions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json; // Keep for potential future use, but not for current claims
using Saaed360Modern.Application.Abstractions.AuthService; // Added for IPermissionService
using Microsoft.Extensions.Logging; // Added for logging

namespace Infrastructure.Services.Auth
{
    public sealed class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAppDbContext _dbContext;
        private readonly IPermissionService _permissionService; // Added IPermissionService
        private readonly ILogger<CurrentUserService> _logger; // Added logger

        // Cached user for the current request scope
        private CurrentUser? _cachedCurrentUser;

        public CurrentUserService(
            IHttpContextAccessor httpContextAccessor,
            IAppDbContext dbContext,
            IPermissionService permissionService, // Added IPermissionService
            ILogger<CurrentUserService> logger) // Added logger
        {
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
            _permissionService = permissionService; // Added IPermissionService
            _logger = logger; // Added logger
        }

        public async Task<CurrentUser?> GetCurrentUserAsync()
        {
            // --- Request-Scoped Caching --- 
            if (_cachedCurrentUser != null)
            {
                _logger.LogDebug("Returning cached CurrentUser for request.");
                return _cachedCurrentUser;
            }
            // --- End Caching ---

            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext == null)
            {
                _logger.LogWarning("HttpContext is null, cannot retrieve current user.");
                return null;
            }

            var user = httpContext.User;
            if (user == null || !(user.Identity?.IsAuthenticated ?? false))
            {
                _logger.LogDebug("User is not authenticated.");
                return null;
            }

            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier) ?? user.FindFirst(JwtRegisteredClaimNames.Sub);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId))
            {
                _logger.LogWarning("Could not parse UserId claim.");
                return null;
            }

            _logger.LogDebug("Building CurrentUser for UserId: {UserId}", userId);

            // Initialize with data primarily from claims (lean token)
            var currentUser = new CurrentUser
            {
                UserId = userId,
                // Attempt to get basic info from claims first
                UserName = user.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty,
                Email = user.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty,
                FirstName = user.FindFirst(ClaimTypes.GivenName)?.Value ?? string.Empty, // Use standard claim type
                LastName = user.FindFirst(ClaimTypes.Surname)?.Value ?? string.Empty, // Use standard claim type
                PersonId = long.TryParse(user.FindFirst("PersonId")?.Value, out var personId) ? personId : 0L, // Convert string to long safely

                // Initialize permission lists as empty - will be populated by PermissionService
                Roles = new List<Guid>(),
                Areas = new List<long>(),
                Organizations = new List<long>()
            };

            // --- Fetch Permissions using IPermissionService (Leverages Caching) ---
            try
            {
                // Note: IPermissionService needs GetUserRolesAsync method
                // currentUser.Roles = await _permissionService.GetUserRolesAsync(userId); 
                currentUser.Organizations = await _permissionService.GetUserOrganizationIdsAsync(userId);
                currentUser.Areas = await _permissionService.GetUserAreaIdsAsync(userId);
                _logger.LogDebug("Fetched permissions via IPermissionService for UserId: {UserId}", userId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching permissions via IPermissionService for UserId: {UserId}", userId);
                // Decide if failure to get permissions should prevent user retrieval
                // return null; // Or proceed with potentially incomplete user data?
            }
            // --- End Permission Fetching ---

            // --- Fallback for Basic Info (if missing from claims) ---
            // Only fetch basic info if essential claims like UserName are missing
            if (string.IsNullOrEmpty(currentUser.UserName))
            {
                _logger.LogWarning("Essential claims (e.g., UserName) missing from JWT for UserId: {UserId}. Falling back to database for basic info.", userId);
                try
                {
                    // Query only for basic user/person info, not permissions
                    var dbUser = await _dbContext.AspnetUsers
                        .Include(u => u.AspnetMembership) // For Email
                        .Include(u => u.PersonAspnetUsers).ThenInclude(pu => pu.Person) // For Name, UserCode
                        .AsNoTracking() // Read-only for basic info
                        .FirstOrDefaultAsync(u => u.UserId == userId);

                    if (dbUser != null)
                    {
                        var person = dbUser.PersonAspnetUsers.FirstOrDefault()?.Person;
                        currentUser.UserName = dbUser.UserName ?? currentUser.UserName; // Update if found
                        currentUser.Email = dbUser.AspnetMembership?.Email ?? currentUser.Email;
                        currentUser.FirstName = person?.FirstName ?? currentUser.FirstName;
                        currentUser.LastName = person?.LastName ?? currentUser.LastName;
                        currentUser.PersonId = person?.PersonId ?? currentUser.PersonId; // Add if needed
                        _logger.LogDebug("Successfully fetched fallback basic info from DB for UserId: {UserId}", userId);
                    }
                    else
                    {
                        _logger.LogError("User not found in database during fallback check for UserId: {UserId}", userId);
                        return null; // User exists in token but not DB? Critical error.
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Database error during fallback basic info fetch for UserId: {UserId}", userId);
                    return null; // Failed to get essential info
                }
            }
            // --- End Fallback --- 

            // Cache the result for the current request
            _cachedCurrentUser = currentUser;
            _logger.LogInformation("Successfully constructed CurrentUser for UserId: {UserId}", userId);
            return currentUser;
        }

        // Removed claim parsing helpers (ParseLongClaim, ParseGuidListClaim, ParseLongListClaim)
        // Removed permission calculation helpers (ConvertToOrganizations, ConvertToAreasAsync)
    }
}

