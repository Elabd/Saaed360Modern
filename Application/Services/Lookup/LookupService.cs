using Application.DTOs.Lookup;
using Domain.Enums;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence.Entities;
using Microsoft.Extensions.Logging;
using Application.DTOs;

namespace Application.Services.Lookup;

public class LookupService : ILookupService
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<LookupService> _logger;

    public LookupService(ApplicationDbContext context, ILogger<LookupService> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task<List<AreaDto>> GetAreasAsync()
    {
        return await _context.Areas
            .Select(a => new AreaDto
            {
                AreaId = (int)a.AreaId,
                AreaName = a.AreaDescription ?? string.Empty,
                Category = (AreaCategory)a.AreaCategoryId,
                DisplayedOrderIndex = a.DisplayedOrderIndex
            })
            .ToListAsync();
    }

    public async Task<List<AreaDto>> GetAreaById(long personId)
    {
        var areas = await _context.Areas
            .Where(a => _context.PersonAreas
                .Any(pa => pa.PersonId == personId && pa.AreaId == a.AreaId))
            .ToListAsync();
        return areas.Select(a => new AreaDto
        {
            AreaId = (int)a.AreaId,
            AreaName = a.AreaDescription ?? string.Empty,
            Category = (AreaCategory)a.AreaCategoryId,
            CategoryName = a.AreaCategory?.Description ?? string.Empty,
            DisplayedOrderIndex = a.DisplayedOrderIndex
        }).ToList();
    }

    public async Task<List<IncidentPriorityDto>> GetIncidentPriorityList()
    {
        var priorities = await _context.IncidentLevelDims.ToListAsync();
        return priorities.Select(p => new IncidentPriorityDto
        {
            PriorityId = p.IncidentLevelId,
            PriorityName = p.Code ?? string.Empty,
            Description = p.Description ?? string.Empty
        }).ToList();
    }

    public async Task<List<IncidentTypeDto>> GetIncidentTypeListById(int categoryId)
    {
        var types = await _context.IncidentMethodDims
            .Where(t => t.IncidentMethodId == categoryId)
            .ToListAsync();
        return types.Select(t => new IncidentTypeDto
        {
            TypeId = t.IncidentMethodId,
            TypeName = t.Code ?? string.Empty,
            Description = t.Description ?? string.Empty
        }).ToList();
    }

    public async Task<List<IncidentCategoryDto>> GetIncidentCategoryList()
    {
        var categories = await _context.IncidentActivityCategoryDims.ToListAsync();
        return categories.Select(c => new IncidentCategoryDto
        {
            CategoryId = c.IncidentActivityCategoryId,
            CategoryName = c.Code ?? string.Empty,
            Description = c.Description ?? string.Empty
        }).ToList();
    }

    public async Task<List<RoleDto>> GetRolesAsync(Guid userId)
    {
        var roles = await _context.AspnetRoles
            .Where(r => _context.AspnetUsersInRoles.Any(ur => ur.UserId == userId && ur.RoleId == r.RoleId))
            .ToListAsync();
        return roles.Select(r => new RoleDto
        {
            Id = r.RoleId,
            Name = r.RoleName ?? string.Empty,
            Code = r.LoweredRoleName ?? string.Empty,
            IsActive = true,
            Description = r.Description ?? string.Empty
        }).ToList();
    }

    public async Task<SectorAndPatrolDto> GetSectorsAndPatrolsAsync(long areaId, long? personId = null)
    {
        var sectors = await GetSectorByAreaId(areaId, personId);
        var patrols = await GetPatrolForArea(areaId, personId);

        return new SectorAndPatrolDto
        {
            Sectors = sectors,
            Patrols = patrols
        };
    }

    public async Task<List<LookupDto>> GetSectorByAreaId(long areaId, long? personId = null)
    {
        var query = _context.Areas
            .Where(a => a.AreaCategoryId == (int)AreaCategory.Sector);

        if (personId.HasValue)
        {
            query = query.Where(a => _context.PersonAreas
                .Any(pa => pa.PersonId == personId && pa.AreaId == a.AreaId));
        }

        var sectors = await query.ToListAsync();

        return sectors.Select(s => new LookupDto
        {
            Id = s.AreaId,
            Description = s.AreaDescription ?? string.Empty,
            Code = s.Code ?? string.Empty,
            InEmirates = _context.EmirateAreas.Any(ea => ea.AreaId == s.AreaId)
        }).ToList();
    }

    public async Task<List<LookupDto>> GetPatrolForArea(long areaId, long? personId = null)
    {
        var query = _context.Items
            .Where(i => i.ItemCategoryId == 1); // Assuming 1 is the category ID for patrols

        if (personId.HasValue)
        {
            query = query.Where(i => _context.AreaItems
                .Any(ai => ai.AreaId == areaId && ai.ItemId == i.ItemId));
        }

        var patrols = await query.ToListAsync();

        return patrols.Select(p => new LookupDto
        {
            Id = p.ItemId,
            Description = p.Description ?? string.Empty,
            Code = p.OriginalIdent ?? string.Empty,
            InEmirates = true // Since patrols are always in emirates
        }).ToList();
    }

    public List<LookupDto> GetAreaByUserIdandEmirateid(long PersonId, int Emirateid)
    {
        var areas = _context.Areas
            .Where(a => _context.EmirateAreas.Any(ea => ea.EmirateId == Emirateid && ea.AreaId == a.AreaId)
                && _context.PersonAreas.Any(pa => pa.PersonId == PersonId && pa.AreaId == a.AreaId))
            .ToList();

        return areas.Select(a => new LookupDto
        {
            Id = a.AreaId,
            Description = a.AreaDescription ?? string.Empty,
            Code = a.Code ?? string.Empty,
            InEmirates = true
        }).ToList();
    }

    public List<LookupDto> GetEmiratesByUserId(long PersonId)
    {
        var emirates = _context.EmirateDims
            .Where(e => _context.EmirateAreas
                .Any(ea => _context.PersonAreas
                    .Any(pa => pa.PersonId == PersonId && pa.AreaId == ea.AreaId && ea.EmirateId == e.EmirateId)))
            .ToList();

        return emirates.Select(e => new LookupDto
        {
            Id = e.EmirateId,
            Description = e.EmirateName,
            Code = e.EmirateCode ?? string.Empty,
            InEmirates = true
        }).ToList();
    }

    public List<LookupDto> GetReasonByOrganizationId(long organizationId)
    {
        var reasons = _context.IncidentActivityCategoryDims
            .Where(r => r.RowStatusId == 1) // Assuming 1 is the active status
            .ToList();

        return reasons.Select(r => new LookupDto
        {
            Id = r.IncidentActivityCategoryId,
            Description = r.Description ?? string.Empty,
            Code = r.Code ?? string.Empty,
            InEmirates = true
        }).ToList();
    }

    public bool CheckinUpdate(CheckinSendDto checkin)
    {
        try
        {
            var areaItem = new Infrastructure.Persistence.Entities.AreaItem
            {
                AreaId = checkin.AreaId,
                ItemId = checkin.PatrolId,
                IsAttended = true
            };

            _context.AreaItems.Add(areaItem);
            _context.SaveChanges();

            return true;
        }
        catch
        {
            return false;
        }
    }

    public List<LookupDto> GetNotAttendedPersonByAreaId(long areaId)
    {
        var persons = _context.People
            .Where(p => _context.PersonAreas
                .Any(pa => pa.PersonId == p.PersonId && pa.AreaId == areaId))
            .ToList();

        return persons.Select(p => new LookupDto
        {
            Id = p.PersonId,
            Description = p.Description ?? string.Empty,
            Code = p.OriginalIdent ?? string.Empty,
            InEmirates = true
        }).ToList();
    }

    public List<LookupDto> GetObjectionRequestTypes()
    {
        try
        {
            var types = new List<int>() { 4, 7 };
            var requestTypes = _context.ObjectionRequestTypes
                .Where(e => types.Contains(e.RequestTypeId))
                .Select(e => new LookupDto
                {
                    Id = e.RequestTypeId,
                    Description = e.ArabicDescription ?? string.Empty,
                    Code = e.EnglishDescription ?? string.Empty,
                    InEmirates = true
                })
                .ToList();

            return requestTypes;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting objection request types");
            return new List<LookupDto>();
        }
    }

    public List<ObjectionStatusDim> GetObjectionStatus()
    {
        try
        {
            return _context.ObjectionStatusDims.ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting objection status");
            return new List<ObjectionStatusDim>();
        }
    }

} 