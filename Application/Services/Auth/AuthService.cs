using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Application.Helpers;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using Application.DTOs;
using Microsoft.Extensions.Configuration;
using Infrastructure.Persistence.Entities;
using System.Linq;
using System.Security.Cryptography;
using Microsoft.Extensions.Logging;

namespace Application.Services.Auth;

public class AuthService
{
    private readonly ApplicationDbContext _context;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AuthService> _logger;
    private readonly string _jwtKey;
    private readonly string _jwtIssuer;
    private readonly string _jwtAudience;
    private readonly int _accessTokenExpirationMinutes;
    private readonly int _refreshTokenExpirationDays;

    public AuthService(
        ApplicationDbContext context, 
        IConfiguration configuration,
        ILogger<AuthService> logger)
    {
        _context = context;
        _configuration = configuration;
        _logger = logger;
        
        _jwtKey = _configuration["Jwt:Key"] ?? throw new InvalidOperationException("JWT Key is not configured");
        _jwtIssuer = _configuration["Jwt:Issuer"] ?? throw new InvalidOperationException("JWT Issuer is not configured");
        _jwtAudience = _configuration["Jwt:Audience"] ?? throw new InvalidOperationException("JWT Audience is not configured");
        
        // Get token expiration settings with defaults
        _accessTokenExpirationMinutes = int.TryParse(_configuration["Jwt:AccessTokenExpirationMinutes"], out var accessExp) 
            ? accessExp : 60;
        _refreshTokenExpirationDays = int.TryParse(_configuration["Jwt:RefreshTokenExpirationDays"], out var refreshExp) 
            ? refreshExp : 7;
    }

    public async Task<(bool isValid, UserDTO? user)> ValidateUserCredentials(string username, string password)
    {
        try
        {
            var user = await _context.AspnetUsers
                .Include(u => u.AspnetMembership)
                .Include(u => u.AspnetUsersInRoles)
                    .ThenInclude(ur => ur.Role)
                .Include(u => u.PersonAspnetUsers)
                    .ThenInclude(pu => pu.Person)
                .FirstOrDefaultAsync(u => u.LoweredUserName == username.ToLower());

            if (user == null || user.AspnetMembership == null)
            {
                _logger.LogWarning("Login attempt failed for username: {Username}", username);
                return (false, null);
            }

            var isValid = VerifyPassword(password, 
                user.AspnetMembership.Password, 
                user.AspnetMembership.PasswordSalt, 
                user.AspnetMembership.PasswordFormat) && 
                user.AspnetMembership.IsApproved && 
                !user.AspnetMembership.IsLockedOut;

            if (!isValid)
            {
                _logger.LogWarning("Invalid password attempt for username: {Username}", username);
                return (false, null);
            }

            var userDto = await CreateUserDto(user);
            var (accessToken, refreshToken) = await GenerateTokens(userDto);

            userDto.UserToken = new TokenDTO
            {
                Token = accessToken,
                Expiration = DateTime.UtcNow.AddMinutes(_accessTokenExpirationMinutes),
                RefreshToken = refreshToken,
                RefreshTokenExpiration = DateTime.UtcNow.AddDays(_refreshTokenExpirationDays)
            };

            return (true, userDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error validating user credentials for username: {Username}", username);
            throw;
        }
    }

    public async Task<(bool isValid, UserDTO? user)> RefreshToken(string refreshToken, string userId)
    {
        try
        {
            if (string.IsNullOrEmpty(refreshToken) || string.IsNullOrEmpty(userId))
            {
                _logger.LogWarning("Invalid refresh token or user ID");
                return (false, null);
            }

            var user = await _context.AspnetUsers
                .Include(u => u.AspnetMembership)
                .Include(u => u.AspnetUsersInRoles)
                    .ThenInclude(ur => ur.Role)
                .Include(u => u.PersonAspnetUsers)
                    .ThenInclude(pu => pu.Person)
                .FirstOrDefaultAsync(u => u.UserId.ToString() == userId);

            if (user == null)
            {
                _logger.LogWarning("User not found for refresh token: {UserId}", userId);
                return (false, null);
            }

            // TODO: Implement refresh token validation against database
            // For now, we'll just generate new tokens if the user exists

            var userDto = await CreateUserDto(user);
            var (accessToken, newRefreshToken) = await GenerateTokens(userDto);

            userDto.UserToken = new TokenDTO
            {
                Token = accessToken,
                Expiration = DateTime.UtcNow.AddMinutes(_accessTokenExpirationMinutes),
                RefreshToken = newRefreshToken,
                RefreshTokenExpiration = DateTime.UtcNow.AddDays(_refreshTokenExpirationDays)
            };

            return (true, userDto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error refreshing token for user ID: {UserId}", userId);
            throw;
        }
    }

    private async Task<UserDTO> CreateUserDto(AspnetUser user)
    {
        var roleIds = user.AspnetUsersInRoles.Select(ur => ur.RoleId).ToList();
        var pageRolesId = await _context.PageRoles
            .Where(pr => roleIds.Contains(pr.RoleId))
            .Select(pr => pr.PageId)
            .ToListAsync();

        var accessiblePages = new List<ApplicationPageDTO>();
        if (roleIds.Any())
        {
            accessiblePages = await _context.ApplicationPages
                .Where(ap => ap.Url != null && pageRolesId.Contains(ap.Id))
                .Select(ap => new ApplicationPageDTO
                {
                    Id = ap.Id,
                    PageName = ap.PageName ?? string.Empty,
                    IconPath = ap.IconPath ?? string.Empty,
                    Url = ap.Url,
                    IsAdmin = ap.IsAdmin ?? false
                })
                .ToListAsync();
        }

        var person = user.PersonAspnetUsers.FirstOrDefault()?.Person;

        return new UserDTO
        {
            Id = person?.PersonId ?? user.UserId.GetHashCode(),
            
            UserCode = person?.Description ?? string.Empty,
            UserName = user.UserName ?? user.UserName,
            Email = user.AspnetMembership.Email,
            Roles = user.AspnetUsersInRoles.Select(ur => new RoleDTO
            {
                Description = ur.Role.Description,
                RoleId = ur.Role.RoleId,
                RoleName = ur.Role.RoleName
            }).ToList(),
            AccessablePages = accessiblePages
        };
    }

    private async Task<(string accessToken, string refreshToken)> GenerateTokens(UserDTO user)
    {
        var accessToken = GenerateJwtToken(user);
        var refreshToken = await GenerateRefreshToken(user.Id.ToString());
        return (accessToken, refreshToken);
    }

    private string GenerateJwtToken(UserDTO user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
            new Claim(JwtRegisteredClaimNames.UniqueName, user.FullName),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim("FullName", user.FullName),
            new Claim("UserCode", user.UserCode)
        };



        var token = new JwtSecurityToken(
            issuer: _jwtIssuer,
            audience: _jwtAudience,
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(_accessTokenExpirationMinutes),
            signingCredentials: credentials
        );

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    private async Task<string> GenerateRefreshToken(string userId)
    {
        var randomNumber = new byte[32];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(randomNumber);
        var refreshToken = Convert.ToBase64String(randomNumber);

        // TODO: Store refresh token in database with userId and expiration
        // This would allow for token revocation and proper validation

        return refreshToken;
    }

    private bool VerifyPassword(string password, string hashedPassword, string salt, int passwordFormat)
    {
        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashedPassword) || string.IsNullOrEmpty(salt))
            return false;

        string computedHash;
        switch (passwordFormat)
        {
            case 0: // Clear text (not recommended)
                computedHash = password;
                break;
            case 1: // Hashed
                computedHash = HashHelper.GenerateHash(password, salt);
                break;
            default:
                return false;
        }

        return hashedPassword.Equals(computedHash, StringComparison.Ordinal);
    }
} 