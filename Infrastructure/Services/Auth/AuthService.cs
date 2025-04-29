
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

    // Updated return type to AuthResult?
    public async Task<AuthResult?> ValidateUserCredentialsAsync(string username, string password, CancellationToken ct = default)
    {
        // Input validation
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        {
            _logger.LogWarning("Login attempt with empty username or password.");
            return null; // Return null for AuthResult?
        }

        _logger.LogInformation("Attempting credential validation for username: {Username}", username);

        AspnetUser? user = null;
        try
        {
            // --- USING THE COMPILED QUERY ---
            user = await _getUserForValidationCompiledAsync((ApplicationDbContext)_db, username.ToLower());
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Database error during user lookup for username: {Username}", username);
            return null; // Return null for AuthResult?
        }

        if (user == null || user.AspnetMembership == null)
        {
            _logger.LogWarning("User not found or membership missing for username: {Username}", username);
            return null; // Return null for AuthResult?
        }

        // --- Enhancement: Check for account lockout (Example) ---
        // if (user.AspnetMembership.IsLockedOut)
        // {
        //     _logger.LogWarning("Login attempt failed for locked out user: {Username}, UserId: {UserId}", username, user.UserId);
        //     return null; // Return null for AuthResult?
        // }
        // --- End Lockout Check ---

        if (!VerifyPassword(password, user.AspnetMembership.Password, user.AspnetMembership.PasswordSalt, user.AspnetMembership.PasswordFormat))
        {
            _logger.LogWarning("Invalid password attempt for username: {Username}, UserId: {UserId}", username, user.UserId);
            // --- Enhancement: Handle failed login attempt (Example) ---
            // ... (lockout logic as before)
            return null; // Return null for AuthResult?
        }

        // --- Enhancement: Reset failed attempts on successful login (Example) ---
        // ... (reset logic as before)

        _logger.LogInformation("Credentials validated successfully for username: {Username}, UserId: {UserId}", username, user.UserId);
        try
        {
            // Pass null for rotatedRefreshToken for initial login
            // BuildLoginResponseAsync now returns AuthResult
            return await BuildLoginResponseAsync(user, null, ct);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error building login response for UserId: {UserId}", user.UserId);
            return null; // Return null for AuthResult?
        }
    }

    // Updated return type to AuthResult?
    public async Task<AuthResult?> RefreshTokenAsync(string refreshToken, string userId, CancellationToken ct = default)
    {
        _logger.LogInformation("Attempting to refresh token for UserId: {UserId}", userId);

        // Input validation
        if (string.IsNullOrWhiteSpace(refreshToken) || string.IsNullOrWhiteSpace(userId))
        {
            _logger.LogWarning("Token refresh attempt with empty refresh token or userId. UserId: {UserId}", userId);
            return null; // Return null for AuthResult?
        }

        if (!Guid.TryParse(userId, out Guid userGuid))
        {
            _logger.LogWarning("Invalid UserId format provided for token refresh: {UserId}", userId);
            return null; // Return null for AuthResult?
        }

        try
        {
            // 1. Validate the refresh token and get the associated user
            var user = await _refreshTokenStore.ValidateAsync(refreshToken, ct);

            // 2. Check if validation succeeded and if the token belongs to the requesting user
            if (user == null)
            {
                _logger.LogWarning("Refresh token validation failed (token not found, expired, or revoked). Provided UserId: {UserId}", userId);
                return null; // Return null for AuthResult?
            }

            if (user.UserId != userGuid)
            {
                _logger.LogWarning("Refresh token UserId mismatch. Token belongs to UserId {TokenUserId}, but request was for UserId {RequestedUserId}", user.UserId, userId);
                return null; // Return null for AuthResult?
            }

            // --- Enhancement: Check if user account is locked (even during refresh) ---
            // if (user.AspnetMembership?.IsLockedOut ?? false)
            // {
            //     _logger.LogWarning("Token refresh attempt failed for locked out user: {Username}, UserId: {UserId}", user.UserName, user.UserId);
            //     return null; // Return null for AuthResult?
            // }
            // --- End Lockout Check ---

            // 3. Rotate the token: Invalidate the old one and issue a new one
            var newRotatedRefreshToken = await _refreshTokenStore.RotateAsync(userGuid, refreshToken, ct);
            _logger.LogInformation("Successfully rotated refresh token for UserId: {UserId}", userId);

            // 4. Build the response using the validated user and the NEW rotated refresh token
            // BuildLoginResponseAsync now returns AuthResult
            return await BuildLoginResponseAsync(user, newRotatedRefreshToken, ct);
        }
        catch (DbUpdateConcurrencyException ex)
        {
            _logger.LogWarning(ex, "Concurrency error during token rotation for UserId: {UserId}. Possible token reuse attempt?", userId);
            return null; // Return null for AuthResult?
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred during token refresh process for UserId: {UserId}", userId);
            return null; // Return null for AuthResult?
        }
    }

    // Updated return type to AuthResult
    private async Task<AuthResult> BuildLoginResponseAsync(AspnetUser user, string? rotatedRefreshToken = null, CancellationToken ct = default)
    {
        _logger.LogInformation("Building login response for UserId: {UserId}", user.UserId);

        // BuildUserInfoAsync now primarily focuses on fetching data NOT already included
        var userInfo = await BuildUserInfoAsync(user, ct);

        var firstName = userInfo.Person?.FirstName ?? string.Empty;
        var lastName = userInfo.Person?.LastName ?? userInfo.Person?.MiddleName??string.Empty;
        var personId = userInfo.Person?.PersonId ?? 0;

        // Fix for the error CS1503: Argument 2: cannot convert from 'long' to 'System.Security.Claims.ClaimsIdentity?'
        // The issue is that the `Claim` constructor expects the second argument to be a string, not a long.
        // Convert `personId` to a string using `.ToString()`.

        var extraClaims = new List<Claim>
        {
            new Claim(ClaimTypes.GivenName, firstName),
            new Claim(ClaimTypes.Surname, lastName),
            new Claim("PersonId", personId.ToString()), // Fixed: Convert long to string
        };

        // Generate the JWT access token
        var accessToken = _jwtFactory.Create(user.UserId, userInfo.Email, extraClaims);

        // Use the provided rotated token if available (from refresh), otherwise issue a new one (from login)
        var refreshTokenString = rotatedRefreshToken ?? await _refreshTokenStore.IssueAsync(user.UserId, ct);

        // Get expiry times from configuration with defaults
        var accessTokenExpiryMinutes = 60;// _configuration.GetValue<int?>("Jwt:ExpiryInMinutes") ?? 60;
        var refreshTokenExpiryDays = 7;//_configuration.GetValue<int?>("Jwt:RefreshTokenExpiryInDays") ?? 7; // Ensure this matches EfRefreshTokenStore logic
        var refreshTokenExpiryDate = DateTime.UtcNow.AddDays(refreshTokenExpiryDays);

        _logger.LogInformation("Successfully built login response for UserId: {UserId}", user.UserId);

        // Create the client-facing response (without refresh token details)
        var clientResponse = new LoginResponse
        {
            AccessToken = accessToken,
            AccessTokenExpiration = DateTime.UtcNow.AddMinutes(accessTokenExpiryMinutes),
            User = new UserInfoDto
            {
                UserId = userInfo.UserId,
                UserName = userInfo.UserName,
                Email = userInfo.Email,
                FullName = userInfo.Person != null ? $"{userInfo.Person.FirstName} {userInfo.Person.MiddleName} {userInfo.Person.LastName}".Trim() : string.Empty
                // PrimaryRole = userInfo.Roles?.FirstOrDefault() // Example: Set PrimaryRole
            }
        };

        // Create the internal details for cookie setting
        var cookieDetails = new RefreshTokenDetails
        {
            Token = refreshTokenString,
            Expiration = refreshTokenExpiryDate
        };

        // Return the combined AuthResult
        return new AuthResult(clientResponse, cookieDetails);
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

        // NOTE: Organization and Area calculation logic is removed from here
        // as it's no longer needed for the JWT token.
        // It should be handled by the IPermissionService implementation.

        return new UserDTO
        {
            UserId = user.UserId,
            UserName = user.UserName,
            Email = user.AspnetMembership?.Email ?? string.Empty,
            Person = person,
         //   AccessiblePages = accessiblePages,
            // Organizations = organizations, // Removed
            // Areas = areas // Removed
        };
    }

    // --- Helper: Verify Password ---
    private bool VerifyPassword(string enteredPassword, string storedPasswordHash, string storedSalt, int passwordFormat)
    {
        // IMPORTANT: This assumes the password format used by your AspNetMembership provider.
        // Adapt this logic based on your actual hashing algorithm (e.g., ASP.NET Identity uses PBKDF2).
        // The current implementation seems to assume a simple Hash + Salt approach.
        // If using ASP.NET Identity Hasher, you'd use PasswordHasher<AspnetUser>.VerifyHashedPassword.

        if (passwordFormat == 1) // Assuming 1 means Hashed
        {
            // Warning: Storing plain text passwords (format 0?) is highly insecure.
            if (string.IsNullOrEmpty(storedSalt))
            {
                _logger.LogError("Password format is Hashed but salt is missing.");
                return false;
            }
            // This needs to replicate the *exact* hashing algorithm used when the password was stored.
            // Example using a hypothetical HashPasswordWithSalt function:
            // string hashedEnteredPassword = HashPasswordWithSalt(enteredPassword, storedSalt);
            // return storedPasswordHash.Equals(hashedEnteredPassword);

            // Placeholder - REPLACE with your actual hash verification logic
            _logger.LogWarning("Password verification logic needs to be implemented correctly based on the hashing algorithm used.");
            // For demonstration, assuming a simple (and insecure) check if the hash matches a known value
            // This is NOT a real verification
            // return storedPasswordHash == Application.Helpers.EncryptionHelper.HashPassword(enteredPassword, storedSalt);
            return true; // TEMPORARY - REMOVE THIS AND IMPLEMENT PROPER VERIFICATION
        }
        else // Assuming 0 means Clear text (Highly discouraged!)
        {
            _logger.LogWarning("Password format is Clear text. This is insecure.");
            return storedPasswordHash.Equals(enteredPassword);
        }
    }
}

