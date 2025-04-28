using Application.Abstractions;
using Application.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Saaed360Modern.Application.Abstractions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace Infrastructure.Services.Auth
{
    public sealed class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAppDbContext _dbContext;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor, IAppDbContext dbContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _dbContext = dbContext;
        }

        public async Task<CurrentUser?> GetCurrentUserAsync()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            //if (user == null || !user.Identity?.IsAuthenticated ?? true)
            if (user == null || !(user.Identity?.IsAuthenticated ?? false))

                return null;

            var userIdClaim = user.FindFirst(ClaimTypes.NameIdentifier) ?? user.FindFirst(JwtRegisteredClaimNames.Sub);
            if (userIdClaim == null || !Guid.TryParse(userIdClaim.Value, out var userId))
                return null;

            var currentUser = new CurrentUser
            {
                UserId = userId,
                PersonId = ParseLongClaim(user, "PersonId"),
                UserName = user.FindFirst(ClaimTypes.Name)?.Value ?? string.Empty,
                Email = user.FindFirst(ClaimTypes.Email)?.Value ?? string.Empty,
                FirstName = user.FindFirst("FirstName")?.Value ?? string.Empty,
                LastName = user.FindFirst("LastName")?.Value ?? string.Empty,
                MiddleName = user.FindFirst("MiddleName")?.Value ?? string.Empty,
                UserCode = user.FindFirst("UserCode")?.Value ?? string.Empty,
                Roles = ParseGuidListClaim(user, "Roles"),
                Areas = ParseLongListClaim(user, "Areas"),
                Organizations = ParseLongListClaim(user, "Organizations")
            };

            // 🔥 If JWT is missing critical fields, fallback and load fresh from DB
            if (string.IsNullOrEmpty(currentUser.UserName) || currentUser.Roles.Count == 0 || currentUser.Organizations.Count == 0)
            {
                var dbUser = await _dbContext.AspnetUsers
                    .Include(u => u.AspnetMembership)
                    .Include(u => u.AspnetUsersInRoles)
                        .ThenInclude(ur => ur.Role)
                            .ThenInclude(r => r.OrganizationRoles)
                    .Include(u => u.PersonAspnetUsers)
                        .ThenInclude(pu => pu.Person)
                            .ThenInclude(p => p.PersonAreas)
                    .FirstOrDefaultAsync(u => u.UserId == userId);

                if (dbUser == null)
                    return null;

                var person = dbUser.PersonAspnetUsers.FirstOrDefault()?.Person;

                currentUser.PersonId = person?.PersonId ?? 0;
                currentUser.UserName = dbUser.UserName ?? string.Empty;
                currentUser.Email = dbUser.AspnetMembership?.Email ?? string.Empty;
                currentUser.FirstName = person?.FirstName ?? string.Empty;
                currentUser.LastName = person?.LastName ?? string.Empty;
                currentUser.MiddleName = person?.MiddleName ?? string.Empty;
                currentUser.UserCode = person?.Description ?? string.Empty;
                currentUser.Roles = dbUser.AspnetUsersInRoles.Select(r => r.Role.RoleId).ToList();
                currentUser.Organizations = ConvertToOrganizations(dbUser.AspnetUsersInRoles.Select(r => r.Role).ToList());
                currentUser.Areas = await ConvertToAreasAsync(person);
            }

            return currentUser;
        }

        // Helper to safely parse long from claim
        private static long ParseLongClaim(ClaimsPrincipal user, string claimType)
        {
            var value = user.FindFirst(claimType)?.Value;
            return long.TryParse(value, out var result) ? result : 0;
        }

        // Helper to safely parse Guid list from JSON claim
        private static List<Guid> ParseGuidListClaim(ClaimsPrincipal user, string claimType)
        {
            var value = user.FindFirst(claimType)?.Value;
            if (string.IsNullOrEmpty(value))
                return new List<Guid>();

            try
            {
                return JsonSerializer.Deserialize<List<Guid>>(value) ?? new List<Guid>();
            }
            catch
            {
                return new List<Guid>();
            }
        }

        // Helper to safely parse long list from JSON claim
        private static List<long> ParseLongListClaim(ClaimsPrincipal user, string claimType)
        {
            var value = user.FindFirst(claimType)?.Value;
            if (string.IsNullOrEmpty(value))
                return new List<long>();

            try
            {
                return JsonSerializer.Deserialize<List<long>>(value) ?? new List<long>();
            }
            catch
            {
                return new List<long>();
            }
        }

        private static List<long> ConvertToOrganizations(List<Domain.Entities.AspnetRole> roles)
        {
            if (roles == null || roles.Count == 0)
                return new List<long>();

            return roles
                .SelectMany(r => r.OrganizationRoles)
                .Select(or => (long)or.OrganizationId)
                .Distinct()
                .ToList();
        }

        private async Task<List<long>> ConvertToAreasAsync(Domain.Entities.Person? person)
        {
            if (person == null || person.PersonAreas == null)
                return new List<long>();

            var areaIds = person.PersonAreas.Select(pa => (long)pa.AreaId).ToList();
            var allAreas = new HashSet<long>(areaIds);

            var firstLevel = await _dbContext.AreaAssociations
                .Where(a => areaIds.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync();

            allAreas.UnionWith(firstLevel);

            var secondLevel = await _dbContext.AreaAssociations
                .Where(a => firstLevel.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync();

            allAreas.UnionWith(secondLevel);

            var thirdLevel = await _dbContext.AreaAssociations
                .Where(a => secondLevel.Contains(a.AreaId))
                .Select(a => a.RelatedAreaId)
                .ToListAsync();

            allAreas.UnionWith(thirdLevel);

            return allAreas.ToList();
        }
    }
}
