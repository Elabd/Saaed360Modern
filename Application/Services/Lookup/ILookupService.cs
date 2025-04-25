using Application.DTOs;
using Application.DTOs.Lookup;
using Domain.Entities;

namespace Application.Services.Lookup;

public interface ILookupService
{
    Task<List<AreaDto>> GetAreasAsync();
    Task<List<AreaDto>> GetAreaById(long personId);
    Task<List<IncidentPriorityDto>> GetIncidentPriorityList();
    Task<List<IncidentTypeDto>> GetIncidentTypeListById(int categoryId);
    Task<List<IncidentCategoryDto>> GetIncidentCategoryList();
    Task<List<RoleDto>> GetRolesAsync(Guid userId);
    Task<SectorAndPatrolDto> GetSectorsAndPatrolsAsync(long areaId, long? personId = null);
    Task<List<LookupDto>> GetSectorByAreaId(long areaId, long? personId = null);
    Task<List<LookupDto>> GetPatrolForArea(long areaId, long? personId = null);
    List<LookupDto> GetAreaByUserIdandEmirateid(long PersonId, int Emirateid);
    List<LookupDto> GetEmiratesByUserId(long PersonId);
    List<LookupDto> GetReasonByOrganizationId(long organizationId);
    bool CheckinUpdate(CheckinSendDto checkin);
    List<LookupDto> GetNotAttendedPersonByAreaId(long areaId);
    
    // New methods
    List<LookupDto> GetObjectionRequestTypes();
    List<ObjectionStatusDim> GetObjectionStatus();
}