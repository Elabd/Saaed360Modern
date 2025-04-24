using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.DTOs;
using Application.Services;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Application.Services.Lookup;

namespace Application.Services
{
    public class ObjectionService : IObjectionService
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<ObjectionService> _logger;
        private readonly ILookupService _lookupService;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ObjectionService(
            ApplicationDbContext context,
            ILogger<ObjectionService> logger,
            ILookupService lookupService,
            IConfiguration configuration,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _lookupService = lookupService ?? throw new ArgumentNullException(nameof(lookupService));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<List<ViewObjection>> GetResultObjectionsAsync(SearchObjectionDTO search)
        {
            if (search == null)
            {
                throw new ArgumentNullException(nameof(search));
            }

            try
            {
                // Get user information from claims
                var user = _httpContextAccessor.HttpContext?.User;
                if (user != null)
                {
                    search.UserName = user.FindFirst(ClaimTypes.Name)?.Value;
                    if (long.TryParse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value, out long userId))
                    {
                        search.UserId = userId;
                    }
                }

                var query = _context.ViewObjections.AsQueryable();

                // Apply filters
                if (search.from.HasValue)
                {
                    query = query.Where(x => x.ObjectionDate >= search.from);
                }
                if (search.to.HasValue)
                {
                    query = query.Where(x => x.ObjectionDate <= search.to);
                }
                if (search.statusId > 0)
                {
                    if (search.statusId == 1)
                    {
                        query = query.Where(x => x.StatusId == 1 || x.StatusId == 7);
                    }
                    else
                    {
                        query = query.Where(x => x.StatusId == search.statusId);
                    }
                }
                if (!string.IsNullOrEmpty(search.ReportNumber))
                {
                    query = query.Where(x => x.ReportNumber == search.ReportNumber);
                }
                if (search.RequestNumber > 0)
                {
                    query = query.Where(x => x.ObjectionId == search.RequestNumber);
                }
                if (search.typeId > 0)
                {
                    query = query.Where(x => x.RequestTypeId == search.typeId);
                }
                if (search.areaId != null && search.areaId.Any())
                {
                    query = query.Where(x => x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value));
                }
                else if (!IsSuperUser(search.UserName))
                {
                    var emirates =  _lookupService.GetEmiratesByUserId(search.UserId.Value);
                    var emirateIds = emirates.Select(x => x.Id);
                    query = query.Where(x =>
                        (x.AreaId.HasValue && search.areaId.Contains(x.AreaId.Value)) ||
                        (!x.AreaId.HasValue && !x.ObjectionEmirateId.HasValue) ||
                        (x.ObjectionEmirateId.HasValue && emirateIds.Contains(x.ObjectionEmirateId.Value)) ||
                        x.AreaId == null);
                }

                return await query.OrderBy(x => x.ObjectionDate).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting objection results for search criteria: {@SearchCriteria}", search);
                return new List<ViewObjection>();
            }
        }

        private bool IsSuperUser(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return false;
            }

            var superUsers = GetSuperUsers();
            return superUsers.Contains(userName);
        }

        private List<string> GetSuperUsers()
        {
            try
            {
                var superUsers = new List<string>();
                var keyConfig = _configuration["SuperUsers"];
                
                if (string.IsNullOrEmpty(keyConfig))
                {
                    return superUsers;
                }

                return keyConfig.Contains(",")
                    ? keyConfig.Split(',').ToList()
                    : new List<string> { keyConfig };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting super users from configuration");
                return new List<string>();
            }
        }
    }
} 