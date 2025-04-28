using Application.Abstractions.AuthService;
using Application.DTOs;
using Application.DTOs.Auth;
using Application.Helpers;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Saaed360Modern.Application.Abstractions;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text.Json;

namespace Infrastructure.Services.Auth;

public sealed class AuthService : IAuthService
{
    private readonly IAppDbContext _db;
    private readonly IJwtFactory _jwtFactory;
    private readonly IRefreshTokenStore _refreshTokenStore;
    private readonly ILogger<AuthService> _logger;

    public AuthService(
        IAppDbContext db,
        IJwtFactory jwtFactory,
        IRefreshTokenStore refreshTokenStore,
        ILogger<AuthService> logger)
    {
        _db = db;
        _jwtFactory = jwtFactory;
        _refreshTokenStore = refreshTokenStore;
        _logger = logger;
    }

    public async Task<LoginResponse?> ValidateUserCredentialsAsync(string username, string password, CancellationToken ct = default)
    {
        //var user = await _db.AspnetUsers
        //    .Include(u => u.AspnetMembership)
        //    .FirstOrDefaultAsync(u => u.LoweredUserName == username.ToLower(), ct);

        var user = await _db.AspnetUsers
                .Include(u => u.AspnetMembership)
                .Include(u => u.AspnetUsersInRoles)
                    .ThenInclude(ur => ur.Role)
                .Include(u => u.PersonAspnetUsers)
                    .ThenInclude(pu => pu.Person)
                .FirstOrDefaultAsync(u => u.LoweredUserName == username.ToLower());
        if (user == null || user.AspnetMembership == null ||
            !VerifyPassword(password, user.AspnetMembership.Password, user.AspnetMembership.PasswordSalt, user.AspnetMembership.PasswordFormat))
        {
            return null;
        }

        return await BuildLoginResponseAsync(user, ct);
    }

    public async Task<LoginResponse?> RefreshTokenAsync(string refreshToken, string userId, CancellationToken ct = default)
    {
        var user = await _refreshTokenStore.ValidateAsync(refreshToken, ct);

        if (user == null || user.UserId.ToString() != userId)
            return null;

        return await BuildLoginResponseAsync(user, ct);
    }

    private async Task<LoginResponse> BuildLoginResponseAsync(AspnetUser user, CancellationToken ct)
    {
        var userInfo = await BuildUserInfoAsync(user, ct);
        // Extracting firstName, lastName, and userCode from userInfo.Person
        var firstName = userInfo.Person?.FirstName ?? string.Empty;
        var lastName = userInfo.Person?.LastName ?? string.Empty;
        var userCode = userInfo.Person?.Description ?? string.Empty;

        var extraClaims = new List<Claim>
        {
            new Claim("FirstName", firstName),
            new Claim("LastName", lastName),
            new Claim("UserCode", userCode),
            new Claim("Organizations", JsonSerializer.Serialize(userInfo.Organizations)),
            new Claim("Areas", JsonSerializer.Serialize(userInfo.Areas))
        };

        var token = _jwtFactory.Create(user.UserId, userInfo.Email, extraClaims);

        var refreshToken = await _refreshTokenStore.IssueAsync(user.UserId, ct);

        return new LoginResponse
        {
            AccessToken = token,
            AccessTokenExpiration = DateTime.UtcNow.AddMinutes(60),
            RefreshToken = refreshToken,
            RefreshTokenExpiration = DateTime.UtcNow.AddDays(7),
            User = new UserInfoDto
            {
                UserId = userInfo.UserId,
                UserName = userInfo.UserName,
                Email = userInfo.Email,
                FullName = string.Format("{0} {1} {2}" , userInfo.Person.FirstName, userInfo.Person.MiddleName, userInfo.Person.LastName).Trim()
            }
        };
    }

    private async Task<UserDTO> BuildUserInfoAsync(AspnetUser user, CancellationToken ct)
    {
        var roleIds = user.AspnetUsersInRoles.Select(ur => ur.RoleId).ToList();
        var pageRolesId = await _db.PageRoles
            .Where(pr => roleIds.Contains(pr.RoleId))
            .Select(pr => pr.PageId)
            .ToListAsync();

        var accessiblePages = new List<ApplicationPageDTO>();
        //if (roleIds.Any())
        //{
        //    accessiblePages = await _db.ApplicationPages
        //        .Where(ap => ap.Url != null && pageRolesId.Contains(ap.Id))
        //        .Select(ap => new ApplicationPageDTO
        //        {
        //            Id = ap.Id,
        //            PageName = ap.PageName ?? string.Empty,
        //            IconPath = ap.IconPath ?? string.Empty,
        //            Url = ap.Url,
        //            IsAdmin = ap.IsAdmin ?? false
        //        })
        //        .ToListAsync();
        //}
        var person = user.PersonAspnetUsers.FirstOrDefault()?.Person;

        //if (roleIds.Any())
        //{
        //    accessiblePages = await _db.ApplicationPages
        //        .Where(ap => ap.Url != null && pageRolesId.Contains(ap.Id))
        //        .Select(ap => new ApplicationPageDTO
        //        {
        //            Id = ap.Id,
        //            PageName = ap.PageName ?? string.Empty,
        //            IconPath = ap.IconPath ?? string.Empty,
        //            Url = ap.Url,
        //            IsAdmin = ap.IsAdmin ?? false
        //        })
        //        .ToListAsync();
        //}
        return new UserDTO
        {
            UserId = user.UserId,
            UserName = user.UserName ?? string.Empty,
            Email = user.AspnetMembership?.Email ?? string.Empty,

            Person = person,


            Roles = user.AspnetUsersInRoles.Select(r => r.Role.RoleId).ToList(),
            Organizations = ConvertToOrganizations(user.AspnetUsersInRoles.Select(r => r.Role).ToList()),
            Areas = await ConvertToAreasAsync(person),
            AccessablePages = accessiblePages
        };
    }
     // 🚀 From your old Organization code
    private static List<long> ConvertToOrganizations(List<AspnetRole> roles)
    {
        if (roles == null || roles.Count == 0)
            return new List<long>();

        return roles.SelectMany(r => r.OrganizationRoles)
                    .Select(or => (long)or.OrganizationId)
                    .Distinct()
                    .ToList();
    }

    // 🚀 From your old Area code (converted to async)
    private async Task<List<long>> ConvertToAreasAsync(Person? person)
    {
        if (person == null || person.PersonAreas == null || !person.PersonAreas.Any())
            return new List<long>();

        var areasIds = person.PersonAreas.Select(pa => (long)pa.AreaId).ToList();
        var allRelated = new HashSet<long>(areasIds);

        var firstLevel = await _db.AreaAssociations
            .Where(a => areasIds.Contains(a.AreaId))
            .Select(a => a.RelatedAreaId)
            .ToListAsync();

        allRelated.UnionWith(firstLevel);

        var secondLevel = await _db.AreaAssociations
            .Where(a => firstLevel.Contains(a.AreaId))
            .Select(a => a.RelatedAreaId)
            .ToListAsync();

        allRelated.UnionWith(secondLevel);

        var thirdLevel = await _db.AreaAssociations
            .Where(a => secondLevel.Contains(a.AreaId))
            .Select(a => a.RelatedAreaId)
            .ToListAsync();

        allRelated.UnionWith(thirdLevel);

        return allRelated.ToList();
    }


    private static bool VerifyPassword(string password, string hashedPassword, string salt, int passwordFormat)
    {
        return passwordFormat switch
        {
            0 => password == hashedPassword,
            1 => HashHelper.GenerateHash(password, salt) == hashedPassword,
            _ => false
        };
    }
}




