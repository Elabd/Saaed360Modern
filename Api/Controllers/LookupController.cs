using Application.Services.Lookup;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Application.DTOs.Lookup;
using Domain.Entities;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class LookupController : ControllerBase
{
    private readonly ILookupService _lookupService;
    private readonly ILogger<LookupController> _logger;

    public LookupController(ILookupService lookupService, ILogger<LookupController> logger)
    {
        _lookupService = lookupService;
        _logger = logger;
    }

    [HttpGet("test")]
    [AllowAnonymous]
    public IActionResult Test()
    {
        return Ok(new { message = "Test endpoint works" });
    }

    /// <summary>
    /// Get roles for a specific user
    /// </summary>
    /// <param name="userId">User identifier</param>
    /// <returns>List of roles</returns>
    [HttpGet("roles/{userId:guid}")]
    [ProducesResponseType(typeof(List<RoleDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetRoles(Guid userId)
    {
        try
        {
            var roles = await _lookupService.GetRolesAsync(userId);
            if (roles == null || !roles.Any())
            {
                return NotFound(new { message = "No roles found for the specified user" });
            }
            return Ok(roles);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting roles for user {UserId}", userId);
            return StatusCode(500, new { message = "An error occurred while retrieving roles" });
        }
    }

    /// <summary>
    /// Get sector and patrol information for an area
    /// </summary>
    /// <param name="areaId">Area identifier</param>
    /// <param name="personId">Optional person identifier</param>
    /// <returns>Sector and patrol information</returns>
    [HttpGet("sector-patrol/{areaId:long}")]
    [ProducesResponseType(typeof(SectorAndPatrolDto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetSectorAndPatrol(long areaId, [FromQuery] long? personId = null)
    {
        try
        {
            var result = await _lookupService.GetSectorsAndPatrolsAsync(areaId, personId);
            if (result == null)
            {
                return NotFound(new { message = "No sector and patrol information found for the specified area" });
            }
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting sector and patrol for area {AreaId}", areaId);
            return StatusCode(500, new { message = "An error occurred while retrieving sector and patrol information" });
        }
    }

    /// <summary>
    /// Get sectors by area ID
    /// </summary>
    /// <param name="areaId">Area identifier</param>
    /// <param name="personId">Optional person identifier</param>
    /// <returns>List of sectors</returns>
    [HttpGet("sectors/{areaId:long}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetSectorsByAreaId(long areaId, [FromQuery] long? personId = null)
    {
        try
        {
            var sectors = await _lookupService.GetSectorByAreaId(areaId, personId);
            if (sectors == null || !sectors.Any())
            {
                return NotFound(new { message = "No sectors found for the specified area" });
            }
            return Ok(sectors);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting sectors for area {AreaId}", areaId);
            return StatusCode(500, new { message = "An error occurred while retrieving sectors" });
        }
    }

    /// <summary>
    /// Get patrols for an area
    /// </summary>
    /// <param name="areaId">Area identifier</param>
    /// <param name="personId">Optional person identifier</param>
    /// <returns>List of patrols</returns>
    [HttpGet("patrols/{areaId:long}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetPatrolsForArea(long areaId, [FromQuery] long? personId = null)
    {
        try
        {
            var patrols = await _lookupService.GetPatrolForArea(areaId, personId);
            if (patrols == null || !patrols.Any())
            {
                return NotFound(new { message = "No patrols found for the specified area" });
            }
            return Ok(patrols);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting patrols for area {AreaId}", areaId);
            return StatusCode(500, new { message = "An error occurred while retrieving patrols" });
        }
    }

    /// <summary>
    /// Get areas for a person
    /// </summary>
    /// <param name="personId">Person identifier</param>
    /// <returns>List of areas</returns>
    [HttpGet("areas/{personId:long}")]
    [ProducesResponseType(typeof(List<AreaDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAreasByPersonId(long personId)
    {
        try
        {
            var areas = await _lookupService.GetAreaById(personId);
            if (areas == null || !areas.Any())
            {
                return NotFound(new { message = "No areas found for the specified person" });
            }
            return Ok(areas);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting areas for person {PersonId}", personId);
            return StatusCode(500, new { message = "An error occurred while retrieving areas" });
        }
    }

    /// <summary>
    /// Get incident priorities
    /// </summary>
    /// <returns>List of incident priorities</returns>
    [HttpGet("incident-priorities")]
    [ProducesResponseType(typeof(List<IncidentPriorityDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetIncidentPriorities()
    {
        try
        {
            var priorities = await _lookupService.GetIncidentPriorityList();
            return Ok(priorities);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting incident priorities");
            return StatusCode(500, new { message = "An error occurred while retrieving incident priorities" });
        }
    }

    /// <summary>
    /// Get incident types by category
    /// </summary>
    /// <param name="categoryId">Category identifier</param>
    /// <returns>List of incident types</returns>
    [HttpGet("incident-types/category/{categoryId:int}")]
    [ProducesResponseType(typeof(List<IncidentTypeDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetIncidentTypesByCategory(int categoryId)
    {
        try
        {
            var types = await _lookupService.GetIncidentTypeListById(categoryId);
            if (types == null || !types.Any())
            {
                return NotFound(new { message = "No incident types found for the specified category" });
            }
            return Ok(types);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting incident types for category {CategoryId}", categoryId);
            return StatusCode(500, new { message = "An error occurred while retrieving incident types" });
        }
    }

    /// <summary>
    /// Get incident categories
    /// </summary>
    /// <returns>List of incident categories</returns>
    [HttpGet("incident-categories")]
    [ProducesResponseType(typeof(List<IncidentCategoryDto>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetIncidentCategories()
    {
        try
        {
            var categories = await _lookupService.GetIncidentCategoryList();
            return Ok(categories);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting incident categories");
            return StatusCode(500, new { message = "An error occurred while retrieving incident categories" });
        }
    }

    /// <summary>
    /// Get areas by user ID and emirate ID
    /// </summary>
    /// <param name="personId">Person identifier</param>
    /// <param name="emirateId">Emirate identifier</param>
    /// <returns>List of areas</returns>
    [HttpGet("areas/user/{personId:long}/emirate/{emirateId:int}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetAreasByUserAndEmirate(long personId, int emirateId)
    {
        try
        {
            var areas = _lookupService.GetAreaByUserIdandEmirateid(personId, emirateId);
            if (areas == null || !areas.Any())
            {
                return NotFound(new { message = "No areas found for the specified user and emirate" });
            }
            return Ok(areas);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting areas for person {PersonId} and emirate {EmirateId}", personId, emirateId);
            return StatusCode(500, new { message = "An error occurred while retrieving areas" });
        }
    }

    /// <summary>
    /// Get emirates by user ID
    /// </summary>
    /// <param name="personId">Person identifier</param>
    /// <returns>List of emirates</returns>
    [HttpGet("emirates/user/{personId:long}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetEmiratesByUser(long personId)
    {
        try
        {
            var emirates = _lookupService.GetEmiratesByUserId(personId);
            if (emirates == null || !emirates.Any())
            {
                return NotFound(new { message = "No emirates found for the specified user" });
            }
            return Ok(emirates);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting emirates for person {PersonId}", personId);
            return StatusCode(500, new { message = "An error occurred while retrieving emirates" });
        }
    }

    /// <summary>
    /// Get reasons by organization ID
    /// </summary>
    /// <param name="organizationId">Organization identifier</param>
    /// <returns>List of reasons</returns>
    [HttpGet("reasons/organization/{organizationId:long}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetReasonsByOrganization(long organizationId)
    {
        try
        {
            var reasons = _lookupService.GetReasonByOrganizationId(organizationId);
            if (reasons == null || !reasons.Any())
            {
                return NotFound(new { message = "No reasons found for the specified organization" });
            }
            return Ok(reasons);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting reasons for organization {OrganizationId}", organizationId);
            return StatusCode(500, new { message = "An error occurred while retrieving reasons" });
        }
    }

    /// <summary>
    /// Update check-in status
    /// </summary>
    /// <param name="checkin">Check-in information</param>
    /// <returns>Success status</returns>
    [HttpPost("checkin")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult UpdateCheckin([FromBody] CheckinSendDto checkin)
    {
        try
        {
            var success = _lookupService.CheckinUpdate(checkin);
            if (!success)
            {
                return BadRequest(new { message = "Failed to update check-in status" });
            }
            return Ok(new { message = "Check-in status updated successfully" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error updating check-in status");
            return StatusCode(500, new { message = "An error occurred while updating check-in status" });
        }
    }

    /// <summary>
    /// Get not attended persons by area ID
    /// </summary>
    /// <param name="areaId">Area identifier</param>
    /// <returns>List of not attended persons</returns>
    [HttpGet("not-attended/{areaId:long}")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetNotAttendedPersons(long areaId)
    {
        try
        {
            var persons = _lookupService.GetNotAttendedPersonByAreaId(areaId);
            if (persons == null || !persons.Any())
            {
                return NotFound(new { message = "No not-attended persons found for the specified area" });
            }
            return Ok(persons);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting not-attended persons for area {AreaId}", areaId);
            return StatusCode(500, new { message = "An error occurred while retrieving not-attended persons" });
        }
    }

    /// <summary>
    /// Get objection request types
    /// </summary>
    /// <returns>List of objection request types</returns>
    [HttpGet("objection-request-types")]
    [ProducesResponseType(typeof(List<LookupDto>), StatusCodes.Status200OK)]
    public IActionResult GetObjectionRequestTypes()
    {
        try
        {
            var requestTypes = _lookupService.GetObjectionRequestTypes();
            return Ok(requestTypes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting objection request types");
            return StatusCode(500, new { message = "An error occurred while retrieving objection request types" });
        }
    }

    /// <summary>
    /// Get objection statuses
    /// </summary>
    /// <returns>List of objection statuses</returns>
    [HttpGet("objection-statuses")]
    [ProducesResponseType(typeof(List<ObjectionStatusDim>), StatusCodes.Status200OK)]
    public IActionResult GetObjectionStatuses()
    {
        try
        {
            var statuses = _lookupService.GetObjectionStatus();
            return Ok(statuses);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting objection statuses");
            return StatusCode(500, new { message = "An error occurred while retrieving objection statuses" });
        }
    }
} 