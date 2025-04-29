
using Application.Abstractions.AuthService;
using Application.DTOs;
using Application.DTOs.Auth;
using Application.Helpers;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Added for IConfiguration
using Microsoft.Extensions.Logging;
using Saaed360Modern.Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Services.Auth;

// Consider defining custom exceptions for clearer error handling
// public class InvalidCredentialsException : Exception { }
// public class InvalidRefreshTokenException : Exception { }
// public class UserLockedOutException : Exception { }

public sealed class AuthService : IAuthService
{
    private readonly IAppDbContext _db;
    private readonly IJwtFactory _jwtFactory;
    private readonly IRefreshTokenStore _refreshTokenStore;
    private readonly ILogger<AuthService> _logger;
    private readonly IConfiguration _configuration; // Added IConfiguration

    // --- COMPILED QUERY DEFINITION for User Validation ---
    // Includes necessary data for validation and building the initial response
    private static readonly Func<ApplicationDbContext, string, Task<AspnetUser?>> _getUserForValidationCompiledAsync =
        EF.CompileAsyncQuery((ApplicationDbContext context, string loweredUsername) =>
            context.AspnetUsers
                .Include(u => u.AspnetMembership) // Needed for password validation, lockout checks
                .Include(u => u.AspnetUsersInRoles) // Needed for BuildUserInfoAsync
                    .ThenInclude(ur => ur.Role) // Needed for ConvertToOrganizations
                        .ThenInclude(r => r.OrganizationRoles) // Ensure OrganizationRoles is loaded
                .Include(u => u.PersonAspnetUsers) // Needed for BuildUserInfoAsync
                    .ThenInclude(pu => pu.Person) // Needed for BuildUserInfoAsync
                        .ThenInclude(p => p.PersonAreas) // Needed for ConvertToAreasAsync
                .FirstOrDefault(u => u.LoweredUserName == loweredUsername)); // Removed AsNoTracking() as we might update lockout fields
    // --- END COMPILED QUERY DEFINITION ---

    public AuthService(
        IAppDbContext db,
        IJwtFactory jwtFactory,
        IRefreshTokenStore refreshTokenStore,
        ILogger<AuthService> logger,
        IConfiguration configuration) // Added IConfiguration
    {
        _db = db ?? throw new ArgumentNullException(nameof(db));
        _jwtFactory = jwtFactory ?? throw new ArgumentNullException(nameof(jwtFactory));
        _refreshTokenStore = refreshTokenStore ?? throw new ArgumentNullException(nameof(refreshTokenStore));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration)); // Added IConfiguration
    }

    public async Task<LoginResponse?> ValidateUserCredentialsAsync(string username, string password, CancellationToken ct = default)
    {
        // Input validation
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            _logger.LogWarning("Login attempt with empty username or password.");
            return null; // Or throw ArgumentNullException
        }

        _logger.LogInformation("Attempting credential validation for username: {Username}", username);

        AspnetUser? user = null;
        try
        {
            // --- USING THE COMPILED QUERY ---
            // Note: Removed AsNoTracking() from compiled query to allow potential updates (e.g., lockout)
            user = await _getUserForValidationCompiledAsync((ApplicationDbContext)_db, username.ToLower());
            // --- END USING THE COMPILED QUERY ---
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Database error during user lookup for username: {Username}", username);
            return null; // Or throw a specific infrastructure exception
        }

        if (user == null || user.AspnetMembership == null)
        {
            _logger.LogWarning("User not found or membership missing for username: {Username}", username);
            // Security: Avoid confirming if username exists vs. password is wrong (timing attacks). Log internally but return generic failure.
            return null;
        }

        // --- Enhancement: Check for account lockout (Example) ---
        // Requires AspnetMembership table to have IsLockedOut and FailedPasswordAttemptCount fields
        // if (user.AspnetMembership.IsLockedOut)
        // {
        //     _logger.LogWarning("Login attempt failed for locked out user: {Username}, UserId: {UserId}", username, user.UserId);
        //     // Optionally check LockoutEndDateUtc
        //     return null; // Or throw UserLockedOutException
        // }
        // --- End Lockout Check ---

        if (!VerifyPassword(password, user.AspnetMembership.Password, user.AspnetMembership.PasswordSalt, user.AspnetMembership.PasswordFormat))
        {
            _logger.LogWarning("Invalid password attempt for username: {Username}, UserId: {UserId}", username, user.UserId);

            // --- Enhancement: Handle failed login attempt (Example) ---
            // try
            // {
            //     user.AspnetMembership.FailedPasswordAttemptCount++;
            //     user.AspnetMembership.LastPasswordFailureDate = DateTime.UtcNow;
            //     // Define lockout threshold in configuration
            //     var lockoutThreshold = _configuration.GetValue<int?>("AuthSettings:LockoutThreshold") ?? 5;
            //     if (user.AspnetMembership.FailedPasswordAttemptCount >= lockoutThreshold)
            //     {
            //         user.AspnetMembership.IsLockedOut = true;
            //         user.AspnetMembership.LastLockoutDate = DateTime.UtcNow;
            //         _logger.LogWarning("User account locked due to excessive failed login attempts: {Username}, UserId: {UserId}", username, user.UserId);
            //     }
            //     // Need to attach and save changes if AsNoTracking wasn't used, or refetch user with tracking
            //     // _db.Attach(user.AspnetMembership); // Attach if needed
            //     // _db.Entry(user.AspnetMembership).State = EntityState.Modified;
            //     // await _db.SaveChangesAsync(ct);
            // }
            // catch (Exception ex)
            // {
            //     _logger.LogError(ex, "Error updating failed password attempt count for UserId: {UserId}", user.UserId);
            // }
            // --- End Failed Login Attempt Handling ---

            return null;
        }

        // --- Enhancement: Reset failed attempts on successful login (Example) ---
        // if (user.AspnetMembership.FailedPasswordAttemptCount > 0)
        // {
        //     try
        //     {
        //         user.AspnetMembership.FailedPasswordAttemptCount = 0;
        //         user.AspnetMembership.LastLoginDate = DateTime.UtcNow; // Update last login
        //         // Need to attach and save changes
        //         // await _db.SaveChangesAsync(ct);
        //     }
        //     catch (Exception ex)
        //     {
        //         _logger.LogError(ex, "Error resetting failed password attempt count for UserId: {UserId}", user.UserId);
        //     }
        // }
        // --- End Reset Failed Attempts ---

        _logger.LogInformation("Credentials validated successfully for username: {Username}, UserId: {UserId}", username, user.UserId);
        try
        {
            // Pass null for rotatedRefreshToken for initial login
            return await BuildLoginResponseAsync(user, null, ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error building login response for UserId: {UserId}", user.UserId);
            return null;
        }
    }

    public async Task<LoginResponse?> RefreshTokenAsync(string refreshToken, string userId, CancellationToken ct = default)
    {
        _logger.LogInformation("Attempting to refresh token for UserId: {UserId}", userId);

        // Input validation
        if (string.IsNullOrWhiteSpace(refreshToken) || string.IsNullOrWhiteSpace(userId))
        {
            _logger.LogWarning("Token refresh attempt with empty refresh token or userId. UserId: {UserId}", userId);
            return null;
        }

        if (!Guid.TryParse(userId, out Guid userGuid))
        {
            _logger.LogWarning("Invalid UserId format provided for token refresh: {UserId}", userId);
            return null; // Or throw specific exception for invalid input
        }

        try
        {
            // 1. Validate the refresh token and get the associated user
            // NOTE: Ensure _refreshTokenStore.ValidateAsync includes necessary user data (Membership, Roles, Person etc.)
            var user = await _refreshTokenStore.ValidateAsync(refreshToken, ct);

            // 2. Check if validation succeeded and if the token belongs to the requesting user
            if (user == null)
            {
                _logger.LogWarning("Refresh token validation failed (token not found, expired, or revoked). Provided UserId: {UserId}", userId);
                // Security: Consider revoking the token family if a potentially compromised token is detected.
                return null; // Invalid token
            }

            if (user.UserId != userGuid)
            {
                _logger.LogWarning("Refresh token UserId mismatch. Token belongs to UserId {TokenUserId}, but request was for UserId {RequestedUserId}", user.UserId, userId);
                // Security: This could indicate misuse. Consider revoking tokens for user.UserId.
                return null; // User mismatch
            }

            // --- Enhancement: Check if user account is locked (even during refresh) ---
            // if (user.AspnetMembership?.IsLockedOut ?? false)
            // {
            //     _logger.LogWarning("Token refresh attempt failed for locked out user: {Username}, UserId: {UserId}", user.UserName, user.UserId);
            //     return null;
            // }
            // --- End Lockout Check ---

            // 3. Rotate the token: Invalidate the old one and issue a new one
            var newRotatedRefreshToken = await _refreshTokenStore.RotateAsync(userGuid, refreshToken, ct);
            _logger.LogInformation("Successfully rotated refresh token for UserId: {UserId}", userId);

            // 4. Build the response using the validated user and the NEW rotated refresh token
            return await BuildLoginResponseAsync(user, newRotatedRefreshToken, ct);
        }
        catch (DbUpdateConcurrencyException ex)
        {
            _logger.LogWarning(ex, "Concurrency error during token rotation for UserId: {UserId}. Possible token reuse attempt?", userId);
            // This can happen if the same refresh token is used twice concurrently during rotation.
            // Treat as invalid token.
            return null;
        }
        catch (Exception ex) // Catch more specific exceptions if EfRefreshTokenStore throws them (e.g., TokenNotFoundException)
        {
            _logger.LogError(ex, "Error occurred during token refresh process for UserId: {UserId}", userId);
            return null; // Indicate failure
        }
    }

    // Modified to accept an optional rotated refresh token
    private async Task<LoginResponse> BuildLoginResponseAsync(AspnetUser user, string? rotatedRefreshToken = null, CancellationToken ct = default)
    {
        _logger.LogInformation("Building login response for UserId: {UserId}", user.UserId);

        // BuildUserInfoAsync now primarily focuses on fetching data NOT already included
        var userInfo = await BuildUserInfoAsync(user, ct);

        var firstName = userInfo.Person?.FirstName ?? string.Empty;
        var lastName = userInfo.Person?.LastName ?? string.Empty;
        var userCode = userInfo.Person?.Description ?? string.Empty;

        // Use standard claim types where possible
        var extraClaims = new List<Claim>
        {
            new Claim(ClaimTypes.GivenName, firstName),
            new Claim(ClaimTypes.Surname, lastName),
            new Claim("UserCode", userCode), // Custom claim
            // Consider if serializing complex objects into claims is the best approach vs. separate endpoint
            new Claim("Organizations", JsonSerializer.Serialize(userInfo.Organizations)),
            new Claim("Areas", JsonSerializer.Serialize(userInfo.Areas))
        };

        // Generate the JWT access token
        var accessToken = _jwtFactory.Create(user.UserId, userInfo.Email, extraClaims);

        // Use the provided rotated token if available (from refresh), otherwise issue a new one (from login)
        var refreshTokenToReturn = rotatedRefreshToken ?? await _refreshTokenStore.IssueAsync(user.UserId, ct);

        // Get expiry times from configuration with defaults
        var accessTokenExpiryMinutes = 60;//_configuration.GetValue<int?>("Jwt:ExpiryInMinutes") ?? 60;
        var refreshTokenExpiryDays = 7;//_configuration.GetValue<int?>("Jwt:RefreshTokenExpiryInDays") ?? 7; // Ensure this matches EfRefreshTokenStore logic

        _logger.LogInformation("Successfully built login response for UserId: {UserId}", user.UserId);

        return new LoginResponse
        {
            AccessToken = accessToken,
            AccessTokenExpiration = DateTime.UtcNow.AddMinutes(accessTokenExpiryMinutes),
            RefreshToken = refreshTokenToReturn,
            RefreshTokenExpiration = DateTime.UtcNow.AddDays(refreshTokenExpiryDays),
            User = new UserInfoDto
            {
                UserId = userInfo.UserId,
                UserName = userInfo.UserName,
                Email = userInfo.Email,
                FullName = userInfo.Person != null ? $"{userInfo.Person.FirstName} {userInfo.Person.MiddleName} {userInfo.Person.LastName}".Trim() : string.Empty
            }
        };
    }

    // Assumes user object has Membership, Roles+OrgRoles, Person+PersonAreas included.
    private async Task<UserDTO> BuildUserInfoAsync(AspnetUser user, CancellationToken ct)
    {
        _logger.LogDebug("Building UserDTO for UserId: {UserId}", user.UserId);

        var roleIds = user.AspnetUsersInRoles.Select(ur => ur.RoleId).ToList();
        var person = user.PersonAspnetUsers.FirstOrDefault()?.Person;

        // Fetching accessible pages - This remains a separate query.
        List<ApplicationPageDTO> accessiblePages = new List<ApplicationPageDTO>();
        if (roleIds.Any())
        {
            try
            {
                var pageRolesId = await _db.PageRoles
                   .Where(pr => roleIds.Contains(pr.RoleId))
                   .Select(pr => pr.PageId)
                   .ToListAsync(ct);

                accessiblePages = await _db.ApplicationPages
                    .Where(ap => ap.Url != null && pageRolesId.Contains(ap.Id))
                    .AsNoTracking()
                    .Select(ap => new ApplicationPageDTO
                    {
                        Id = ap.Id,
                        PageName = ap.PageName ?? string.Empty,
                        IconPath = ap.IconPath ?? string.Empty,
                        Url = ap.Url,
                        IsAdmin = ap.IsAdmin ?? false
                    })
                    .ToListAsync(ct);
                _logger.LogDebug("Fetched {PageCount} accessible pages for UserId: {UserId}", accessiblePages.Count, user.UserId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching accessible pages for UserId: {UserId}", user.UserId);
            }
        }
        else
        {
            _logger.LogDebug("No roles found for UserId: {UserId}, skipping page fetch.", user.UserId);
        }

        // Fetch Areas - uses data already included
        var areas = await ConvertToAreasAsync(person, ct);

        // Convert Organizations - uses data already included
        var organizations = ConvertToOrganizations(user.AspnetUsersInRoles.Select(r => r.Role).ToList());

        var userDto = new UserDTO
        {
            UserId = user.UserId,
            UserName = user.UserName ?? string.Empty,
            Email = user.AspnetMembership?.Email ?? string.Empty,
            Person = person,
            Roles = roleIds,
            Organizations = organizations,
            Areas = areas,
            AccessablePages = accessiblePages
        };
        _logger.LogDebug("Finished building UserDTO for UserId: {UserId}", user.UserId);
        return userDto;
    }

    // Assumes roles passed in have OrganizationRoles included
    private static List<long> ConvertToOrganizations(List<AspnetRole> roles)
    {
        if (roles == null || !roles.Any())
            return new List<long>();

        try
        {
            return roles.SelectMany(r => r.OrganizationRoles)
                        .Select(or => (long)or.OrganizationId)
                        .Distinct()
                        .ToList();
        }
        catch (Exception ex)
        {
            // Log this error - indicates includes might be missing
            Console.WriteLine($"Error converting roles to organizations: {ex.Message}"); // Replace with proper logging
            return new List<long>();
        }
    }

    // Assumes person passed in has PersonAreas included
    private async Task<List<long>> ConvertToAreasAsync(Person? person, CancellationToken ct)
    {
        if (person == null)
        {
            _logger.LogDebug("ConvertToAreasAsync: Person is null, returning empty list.");
            return new List<long>();
        }
        if (person.PersonAreas == null || !person.PersonAreas.Any())
        {
            _logger.LogDebug("ConvertToAreasAsync: Person.PersonAreas is null or empty for PersonId: {PersonId}, returning empty list.", person.PersonId);
            return new List<long>();
        }

        var areasIds = person.PersonAreas.Select(pa => (long)pa.AreaId).ToList();
        _logger.LogDebug("ConvertToAreasAsync: Found initial {AreaCount} areas for PersonId: {PersonId}", areasIds.Count, person.PersonId);
        var allRelated = new HashSet<long>(areasIds);

        // This part still requires separate queries.
        try
        {
            var firstLevel = await _db.AreaAssociations
                .Where(a => areasIds.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync(ct);
            allRelated.UnionWith(firstLevel);
            _logger.LogDebug("ConvertToAreasAsync: Found {Count} first-level related areas.", firstLevel.Count);

            if (!firstLevel.Any()) return allRelated.ToList();

            var secondLevel = await _db.AreaAssociations
                .Where(a => firstLevel.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync(ct);
            allRelated.UnionWith(secondLevel);
            _logger.LogDebug("ConvertToAreasAsync: Found {Count} second-level related areas.", secondLevel.Count);

            if (!secondLevel.Any()) return allRelated.ToList();

            var thirdLevel = await _db.AreaAssociations
                .Where(a => secondLevel.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync(ct);
            allRelated.UnionWith(thirdLevel);
            _logger.LogDebug("ConvertToAreasAsync: Found {Count} third-level related areas.", thirdLevel.Count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error fetching related areas for PersonId: {PersonId}", person.PersonId);
            return areasIds; // Return only direct areas on error
        }

        _logger.LogDebug("ConvertToAreasAsync: Total related areas for PersonId: {PersonId} is {Count}", person.PersonId, allRelated.Count);
        return allRelated.ToList();
    }

    // Password verification - Ensure HashHelper uses a strong algorithm (e.g., Argon2, PBKDF2)
    private static bool VerifyPassword(string password, string hashedPassword, string salt, int passwordFormat)
    {
        if (string.IsNullOrEmpty(hashedPassword) || string.IsNullOrEmpty(password))
        {
            return false; // Cannot verify empty inputs
        }

        switch (passwordFormat)
        {
            case 0: // Plain text
                // SECURITY WARNING: Storing plain text passwords is highly insecure.
                // This case should ideally be removed or migrated to a hashed format.
                return password == hashedPassword;
            case 1: // Hashed (Assuming HashHelper.GenerateHash uses a strong algorithm)
                // Ensure HashHelper.GenerateHash is robust and handles potential nulls in salt
                return HashHelper.GenerateHash(password, salt) == hashedPassword;
            default:
                // Log unknown format?
                return false; // Unknown format
        }
    }
}

