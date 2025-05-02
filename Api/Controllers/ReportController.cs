using Application.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Saaed360Modern.Contracts.Wcf;
using System;
using System.Linq; // Added for LINQ operations
using System.ServiceModel;
using System.Threading.Tasks;

namespace Saaed360Modern.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // Apply authorization to the whole controller
    public class ReportController : ControllerBase
    {
        private readonly IReportWcfService _reportService;
        private readonly ILogger<ReportController> _logger;
        private readonly ICurrentUserService _currentUserService; // Inject current user service
        private readonly IReportTemplateService _reportTemplateService; // Assuming you have a report template service

        public ReportController(
            IReportWcfService reportService, 
            ILogger<ReportController> logger, 
            ICurrentUserService currentUserService ,
            IReportTemplateService reportTemplateService
            )
        {
            _reportService = reportService ?? throw new ArgumentNullException(nameof(reportService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));
            _reportTemplateService = reportTemplateService ?? throw new ArgumentNullException(nameof(reportTemplateService));
        }

        // --- Helper Method for WCF Calls ---
        private async Task<IActionResult> ExecuteWcfCall<T>(Func<Task<T>> wcfCall, string operationName = "WCF operation")
        {
            try
            {
                _logger.LogInformation("Executing {OperationName}...", operationName);
                var result = await wcfCall();
                _logger.LogInformation("{OperationName} executed successfully.", operationName);
                
                // Check for specific known 'empty' or 'not found' results if applicable
                // For now, assume null might mean not found for single item gets
                // if (result == null) 
                // {
                //     return NotFound();
                // }
                return Ok(result);
            }
            catch (FaultException fex)
            {
                _logger.LogError(fex, "WCF FaultException occurred during {OperationName}.", operationName);
                // Consider returning specific error details only if safe and appropriate
                return StatusCode(StatusCodes.Status502BadGateway, new { message = $"WCF service error during {operationName}: {fex.Message}" });
            }
            catch (TimeoutException tex)
            {
                 _logger.LogError(tex, "WCF TimeoutException occurred during {OperationName}.", operationName);
                 return StatusCode(StatusCodes.Status504GatewayTimeout, new { message = $"WCF service request timed out during {operationName}." });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred during {OperationName}.", operationName);
                return StatusCode(StatusCodes.Status500InternalServerError, new { message = $"An internal server error occurred during {operationName}." });
            }
        }

        // --- Lookup Endpoints ---
        [NonAction]
        [HttpGet("lookups/affected-lanes")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspAffectedLane()
        {
            return ExecuteWcfCall(() => _reportService.GetRspAffectedLaneAsync(), nameof(GetRspAffectedLane));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-damaged-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspVehicleDamagedType()
        {
            return ExecuteWcfCall(() => _reportService.GetRspVehicleDamagedTypeAsync(), nameof(GetRspVehicleDamagedType));
        }

        [NonAction]
        [HttpGet("lookups/event-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspEventType()
        {
            return ExecuteWcfCall(() => _reportService.GetRspEventTypeAsync(), nameof(GetRspEventType));
        }

        [NonAction]
        [HttpGet("lookups/emirates")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetEmirates()
        {
            return ExecuteWcfCall(() => _reportService.GetEmiratesAsync(), nameof(GetEmirates));
        }

        [NonAction]
        [HttpGet("lookups/emirates/{emirateId}/areas")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAreaBySelectedEmirateId(long emirateId)
        {
            return ExecuteWcfCall(() => _reportService.GetAreaBySelectedEmirateIdAsync(emirateId), nameof(GetAreaBySelectedEmirateId));
        }

        [NonAction]
        [HttpGet("lookups/areas/{areaId}/sectors")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetSectorBySelectedAreaId(long areaId)
        {
            return ExecuteWcfCall(() => _reportService.GetSectorBySelectedAreaIdAsync(areaId), nameof(GetSectorBySelectedAreaId));
        }

        // TODO: Add many more lookup endpoints following this pattern...

        // --- Incident/Report Endpoints ---

        [NonAction]
        [HttpGet("{reportId}")]
        [ProducesResponseType(typeof(ReportDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Assuming null means not found
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetReportByReportId(long reportId)
        {
            // Using the helper, but might need specific null handling
            return await ExecuteWcfCall(async () => 
            {
                var report = await _reportService.GetReportByReportIdAsync(reportId);
                // Explicitly return NotFound if the service returns null for a specific ID lookup
                if (report == null) return null; // Let helper handle Ok(null) or modify helper
                return report;
            }, nameof(GetReportByReportId));
            // Alternative: Handle null explicitly here
            // var result = await ExecuteWcfCall(() => _reportService.GetReportByReportIdAsync(reportId), nameof(GetReportByReportId));
            // if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            // return result;
        }

        [NonAction]
        [HttpPost] // Save new report
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)] // Assuming returns report ID or similar
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // For validation errors
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveIncidentReport([FromBody] ReportDTO reportObject)
        {
            // Add model validation if needed
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveIncidentReportAsync(reportObject), nameof(SaveIncidentReport));
        }

        // TODO: Add endpoints for other report actions (GetIncidentReport, SaveOffline, GetPdf, etc.)

        // --- Vehicle/Driver Endpoints ---

        // TODO: Add endpoints for vehicle/driver lookups (GetVehicleInfo, GetDriverInfo)
        // Requires handling credentials securely - potentially needs configuration or user context

        // --- Misc Endpoints ---
        [NonAction]
        [HttpGet("misc/server-date")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetServerDate()
        {
            return ExecuteWcfCall(() => _reportService.GetServerDateAsync(), nameof(GetServerDate));
        }

        // TODO: Add other misc endpoints (GetGoogleMapAPIKey, SendSurveyMessage, etc.)

        // --- Request/Transfer/Confiscation Endpoints ---

        // TODO: Add endpoints for requests, transfers, confiscations
        // These will likely require injecting ICurrentUserService to get user permissions (areas, roles)





        [NonAction]
        [HttpGet("lookups/rsp-fields-factor")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspFieldsFactor()
        {
            return ExecuteWcfCall(() => _reportService.GetRspFieldsFactorAsync(), nameof(GetRspFieldsFactor));
        }

        [NonAction]
        [HttpGet("lookups/rsp-procedures")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspProcedures()
        {
            return ExecuteWcfCall(() => _reportService.GetRspProceduresAsync(), nameof(GetRspProcedures));
        }

        [NonAction]
        [HttpGet("lookups/rsp-traffic-status")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspTrafficStatus()
        {
            return ExecuteWcfCall(() => _reportService.GetRspTrafficStatusAsync(), nameof(GetRspTrafficStatus));
        }

        [NonAction]
        [HttpGet("lookups/rsp-damaged-level")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspDamagedLevel()
        {
            return ExecuteWcfCall(() => _reportService.GetRspDamagedLevelAsync(), nameof(GetRspDamagedLevel));
        }

        [NonAction]
        [HttpGet("lookups/rsp-incident-lane")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspIncidentLane()
        {
            return ExecuteWcfCall(() => _reportService.GetRspIncidentLaneAsync(), nameof(GetRspIncidentLane));
        }

        [NonAction]
        [HttpGet("lookups/cities")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllCities()
        {
            return ExecuteWcfCall(() => _reportService.GetAllCitiesAsync(), nameof(GetAllCities));
        }

        [NonAction]
        [HttpGet("lookups/sectors/{sectorId}/streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetStreetBySectorId(long sectorId)
        {
            return ExecuteWcfCall(() => _reportService.GetStreetBySectorIdAsync(sectorId), nameof(GetStreetBySectorId));
        }

        [NonAction]
        [HttpGet("lookups/streets/{streetId}/cross-streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetCrossStreetByStreetId(long streetId)
        {
            return ExecuteWcfCall(() => _reportService.GetCrossStreetByStreetIdAsync(streetId), nameof(GetCrossStreetByStreetId));
        }

        [NonAction]
        [HttpGet("lookups/emirates/{emiratesId}/service-center")]
        [ProducesResponseType(typeof(LookupDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetServiceCenterByEmiratesId(long emiratesId)
        {
            // Explicit null check for single item lookup
            var result = await ExecuteWcfCall(() => _reportService.GetServiceCenterByEmiratesIdAsync(emiratesId), nameof(GetServiceCenterByEmiratesId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("lookups/emirates/{emirateId}/cities")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetCityBySelectedEmirateId(long emirateId)
        {
            return ExecuteWcfCall(() => _reportService.GetCityBySelectedEmirateIdAsync(emirateId), nameof(GetCityBySelectedEmirateId));
        }

        [NonAction]
        [HttpGet("lookups/cities/{cityId}/areas")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAreaByCityId(long cityId)
        {
            return ExecuteWcfCall(() => _reportService.GetAreaByCityIdAsync(cityId), nameof(GetAreaByCityId));
        }

        [NonAction]
        [HttpGet("lookups/areas")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllAreas()
        {
            return ExecuteWcfCall(() => _reportService.GetAllAreasAsync(), nameof(GetAllAreas));
        }

        [NonAction]
        [HttpGet("lookups/areas/{areaId}/sectors-alt")] // Alt route to avoid conflict
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetSectorByAreaId(long areaId)
        {
            return ExecuteWcfCall(() => _reportService.GetSectorByAreaIdAsync(areaId), nameof(GetSectorByAreaId));
        }

        [NonAction]
        [HttpGet("lookups/sectors")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllSectors()
        {
            return ExecuteWcfCall(() => _reportService.GetAllSectorsAsync(), nameof(GetAllSectors));
        }

        [NonAction]
        [HttpGet("lookups/streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllStreets()
        {
            return ExecuteWcfCall(() => _reportService.GetAllStreetsAsync(), nameof(GetAllStreets));
        }

        [NonAction]
        [HttpGet("lookups/cross-streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllCrossStreets()
        {
            return ExecuteWcfCall(() => _reportService.GetAllCrossStreetsAsync(), nameof(GetAllCrossStreets));
        }

        [NonAction]
        [HttpGet("lookups/areas/{areaId}/streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetStreetBySelectedAreaId(long areaId)
        {
            return ExecuteWcfCall(() => _reportService.GetStreetBySelectedAreaIdAsync(areaId), nameof(GetStreetBySelectedAreaId));
        }

        [NonAction]
        [HttpGet("lookups/areas/{areaId}/crossing-streets")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetCrossingStreetBySelectedAreaId(long areaId)
        {
            return ExecuteWcfCall(() => _reportService.GetCrossingStreetBySelectedAreaIdAsync(areaId), nameof(GetCrossingStreetBySelectedAreaId));
        }

        [NonAction]
        [HttpGet("lookups/report-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetReportTypeValues([FromQuery] int? statusid)
        {
            return ExecuteWcfCall(() => _reportService.GetReportTypeValuesAsync(statusid), nameof(GetReportTypeValues));
        }

        [NonAction]
        [HttpGet("lookups/weather")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfWeather()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfWeatherAsync(), nameof(GetListOfWeather));
        }

        [NonAction]
        [HttpGet("lookups/road-surface")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfRoadSurface()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfRoadSurfaceAsync(), nameof(GetListOfRoadSurface));
        }

        [NonAction]
        [HttpGet("lookups/road-speed")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfRoadSpeed()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfRoadSpeedAsync(), nameof(GetListOfRoadSpeed));
        }

        [NonAction]
        [HttpGet("lookups/intersections")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfIntersections()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfIntersectionsAsync(), nameof(GetListOfIntersections));
        }

        [NonAction]
        [HttpGet("lookups/accident-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfAccidentTypes()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfAccidentTypesAsync(), nameof(GetListOfAccidentTypes));
        }

        [NonAction]
        [HttpGet("lookups/nationalities")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfNationality()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfNationalityAsync(), nameof(GetListOfNationality));
        }

        [NonAction]
        [HttpGet("lookups/injury-level")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfInjuryLevel()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfInjuryLevelAsync(), nameof(GetListOfInjuryLevel));
        }

        [NonAction]
        [HttpGet("lookups/injury-type")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfInjuryType()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfInjuryTypeAsync(), nameof(GetListOfInjuryType));
        }

        [NonAction]
        [HttpGet("lookups/organisations")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfOrganisation()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfOrganisationAsync(), nameof(GetListOfOrganisation));
        }

        [NonAction]
        [HttpGet("lookups/public-damage-part")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPublicDamagePart()
        {
            return ExecuteWcfCall(() => _reportService.GetPublicDamagePartAsync(), nameof(GetPublicDamagePart));
        }

        [NonAction]
        [HttpGet("lookups/private-damage-part")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPrivateDamagePart()
        {
            return ExecuteWcfCall(() => _reportService.GetPrivateDamagePartAsync(), nameof(GetPrivateDamagePart));
        }

        [NonAction]
        [HttpGet("lookups/organisations/{organisationId}/objects")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfObjectsBySelectedOrganisation(long organisationId)
        {
            return ExecuteWcfCall(() => _reportService.GetListOfObjectsBySelectedOrganisationAsync(organisationId), nameof(GetListOfObjectsBySelectedOrganisation));
        }

        // Note: Plate lookups might need complex query parameters or a POST with a body
        [NonAction]
        [HttpGet("lookups/plate-sources-by-type1")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateSourceByPlateTypeId1([FromQuery] long? plateColor, [FromQuery] long? PlateCategory, [FromQuery] long? plateTypeId)
        {
            return ExecuteWcfCall(() => _reportService.GetPlateSourceByPlateTypeId1Async(plateColor, PlateCategory, plateTypeId), nameof(GetPlateSourceByPlateTypeId1));
        }

        [NonAction]
        [HttpGet("lookups/plate-sources-by-type")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateSourceByPlateTypeId([FromQuery] long? plateTypeId)
        {
            return ExecuteWcfCall(() => _reportService.GetPlateSourceByPlateTypeIdAsync(plateTypeId), nameof(GetPlateSourceByPlateTypeId));
        }

        [NonAction]
        [HttpPost("lookups/plate-sources-by-types")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateSourceByListofPlateTypeIds([FromBody] long[] plateTypeIds)
        {
            if (plateTypeIds == null || plateTypeIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Plate type IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetPlateSourceByListofPlateTypeIdsAsync(plateTypeIds), nameof(GetPlateSourceByListofPlateTypeIds));
        }

        [NonAction]
        [HttpGet("lookups/plate-classes-by-color")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateClassByPlateColorId([FromQuery] long? plateColorId)
        {
            return ExecuteWcfCall(() => _reportService.GetPlateClassByPlateColorIdAsync(plateColorId), nameof(GetPlateClassByPlateColorId));
        }

        [NonAction]
        [HttpPost("lookups/plate-classes-by-colors")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateClassByListofPlateColorId([FromBody] long[] plateColorIds)
        {
            if (plateColorIds == null || plateColorIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Plate color IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetPlateClassByListofPlateColorIdAsync(plateColorIds), nameof(GetPlateClassByListofPlateColorId));
        }

        [NonAction]
        [HttpGet("lookups/plate-colors")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateColor()
        {
            return ExecuteWcfCall(() => _reportService.GetPlateColorAsync(), nameof(GetPlateColor));
        }

        [NonAction]
        [HttpGet("lookups/plate-types-by-class1")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateTypeByPlateClassId1([FromQuery] long? plateClassId, [FromQuery] long? plateColorId)
        {
            return ExecuteWcfCall(() => _reportService.GetPlateTypeByPlateClassId1Async(plateClassId, plateColorId), nameof(GetPlateTypeByPlateClassId1));
        }

        [NonAction]
        [HttpGet("lookups/plate-types-by-class")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateTypeByPlateClassId([FromQuery] long? plateClassId)
        {
            return ExecuteWcfCall(() => _reportService.GetPlateTypeByPlateClassIdAsync(plateClassId), nameof(GetPlateTypeByPlateClassId));
        }

        [NonAction]
        [HttpPost("lookups/plate-types-by-classes")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPlateTypeByListofPlateClassIds([FromBody] long[] plateClassIds)
        {
            if (plateClassIds == null || plateClassIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Plate class IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetPlateTypeByListofPlateClassIdsAsync(plateClassIds), nameof(GetPlateTypeByListofPlateClassIds));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-brands")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleBrands()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleBrandsAsync(), nameof(GetListOfVehicleBrands));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-brands/{vehicleBrandId}/models")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleModelBySelectedVehicleBrand(int vehicleBrandId)
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleModelBySelectedVehicleBrandAsync(vehicleBrandId), nameof(GetListOfVehicleModelBySelectedVehicleBrand));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-models/{vehicleModelId}/types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleTypeBySelectedVehicleModel(int? vehicleModelId)
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleTypeBySelectedVehicleModelAsync(vehicleModelId), nameof(GetListOfVehicleTypeBySelectedVehicleModel));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-types/{vehicleTypeId}/categories")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleCategoryBySelectedVehicleType(int vehicleTypeId)
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleCategoryBySelectedVehicleTypeAsync(vehicleTypeId), nameof(GetListOfVehicleCategoryBySelectedVehicleType));
        }

        [NonAction]
        [HttpPost("lookups/vehicle-models-by-brands")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleModelBySelectedVehicleBrands([FromBody] int[] vehicleBrandIds)
        {
            if (vehicleBrandIds == null || vehicleBrandIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Vehicle brand IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleModelBySelectedVehicleBrandsAsync(vehicleBrandIds), nameof(GetListOfVehicleModelBySelectedVehicleBrands));
        }

        [NonAction]
        [HttpPost("lookups/vehicle-types-by-models")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleTypes([FromBody] int?[] vehicleModelIds)
        {
            if (vehicleModelIds == null || vehicleModelIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Vehicle model IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleTypesAsync(vehicleModelIds), nameof(GetListOfVehicleTypes));
        }

        [NonAction]
        [HttpPost("lookups/vehicle-categories-by-types")] // Use POST for array in body
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleCategoryBySelectedVehicleTypes([FromBody] int?[] vehicleTypeIds)
        {
            if (vehicleTypeIds == null || vehicleTypeIds.Length == 0)
            {
                return Task.FromResult<IActionResult>(BadRequest("Vehicle type IDs cannot be empty."));
            }
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleCategoryBySelectedVehicleTypesAsync(vehicleTypeIds), nameof(GetListOfVehicleCategoryBySelectedVehicleTypes));
        }

        [NonAction]
        [HttpGet("lookups/manufacture-years")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfManufatureYears()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfManufatureYearsAsync(), nameof(GetListOfManufatureYears));
        }

        [NonAction]
        [HttpGet("lookups/manufacture-years/{year}")]
        [ProducesResponseType(typeof(LookupDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetManufactureYearByName(string year)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetManufactureYearByNameAsync(year), nameof(GetManufactureYearByName));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("lookups/countries-of-origin")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfCountryOfOrigins()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfCountryOfOriginsAsync(), nameof(GetListOfCountryOfOrigins));
        }

        [NonAction]
        [HttpGet("lookups/countries-of-origin/{code}")]
        [ProducesResponseType(typeof(LookupDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetOriginCountryByCode(string code)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetOriginCountryByCodeAsync(code), nameof(GetOriginCountryByCode));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("lookups/reasons-of-accident")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllReasonOfAccidents()
        {
            return ExecuteWcfCall(() => _reportService.GetAllReasonOfAccidentsAsync(), nameof(GetAllReasonOfAccidents));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-colors")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehileColors()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehileColorsAsync(), nameof(GetListOfVehileColors));
        }

        [NonAction]
        [HttpGet("lookups/insurance-companies")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfInsuranceCompany()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfInsuranceCompanyAsync(), nameof(GetListOfInsuranceCompany));
        }

        [NonAction]
        [HttpGet("lookups/insurance-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfInsuranceTypes()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfInsuranceTypesAsync(), nameof(GetListOfInsuranceTypes));
        }

        [NonAction]
        [HttpGet("lookups/glass-colors")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfGlassColors()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfGlassColorsAsync(), nameof(GetListOfGlassColors));
        }

        [NonAction]
        [HttpGet("lookups/collision-points")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfCollisionPoints()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfCollisionPointsAsync(), nameof(GetListOfCollisionPoints));
        }

        [NonAction]
        [HttpGet("lookups/chemicals")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfChemicals()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfChemicalsAsync(), nameof(GetListOfChemicals));
        }

        [NonAction]
        [HttpGet("lookups/vehicle-state")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfVehicleState()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfVehicleStateAsync(), nameof(GetListOfVehicleState));
        }

        [NonAction]
        [HttpGet("lookups/reasons-of-accident-alt")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfReasonOfAccidents()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfReasonOfAccidentsAsync(), nameof(GetListOfReasonOfAccidents));
        }

        [NonAction]
        [HttpGet("lookups/license-source")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfLicenseSource()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfLicenseSourceAsync(), nameof(GetListOfLicenseSource));
        }

        [NonAction]
        [HttpGet("lookups/license-category")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfLicenseCategory()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfLicenseCategoryAsync(), nameof(GetListOfLicenseCategory));
        }

        [NonAction]
        [HttpGet("lookups/gender")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfGender()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfGenderAsync(), nameof(GetListOfGender));
        }

        [NonAction]
        [HttpGet("lookups/career")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfCareer()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfCareerAsync(), nameof(GetListOfCareer));
        }

        [NonAction]
        [HttpGet("lookups/education-level")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfEducationLevel()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfEducationLevelAsync(), nameof(GetListOfEducationLevel));
        }

        [NonAction]
        [HttpGet("lookups/escaped-status")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfEscapedStatus()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfEscapedStatusAsync(), nameof(GetListOfEscapedStatus));
        }
        [NonAction]
        [HttpGet("lookups/driver-status")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfDriverStatus()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfDriverStatusAsync(), nameof(GetListOfDriverStatus));
        }
        [NonAction]
        [HttpGet("lookups/driver-drinking-status")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfDriverDrinkingStatus()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfDriverDrinkingStatusAsync(), nameof(GetListOfDriverDrinkingStatus));
        }
        [NonAction]
        [HttpGet("lookups/confiscation-document-types")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfConfiscationsDocumentTypes()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfConfiscationsDocumentTypesAsync(), nameof(GetListOfConfiscationsDocumentTypes));
        }
        [NonAction]
        [HttpGet("lookups/confiscation-status")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetAllConfiscationStatus()
        {
            return ExecuteWcfCall(() => _reportService.GetAllConfiscationStatusAsync(), nameof(GetAllConfiscationStatus));
        }
        [NonAction]
        [HttpGet("lookups/confiscation-locations")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetListOfConfiscationsLocations()
        {
            return ExecuteWcfCall(() => _reportService.GetListOfConfiscationsLocationsAsync(), nameof(GetListOfConfiscationsLocations));
        }
        [NonAction]
        [HttpGet("lookups/report-emirate")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetReportEmirate()
        {
            return ExecuteWcfCall(() => _reportService.GetReportEmirateAsync(), nameof(GetReportEmirate));
        }
        [NonAction]
        [HttpGet("lookups/how-accident-happened")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetHowAccidentHappened()
        {
            return ExecuteWcfCall(() => _reportService.GetHowAccidentHappenedAsync(), nameof(GetHowAccidentHappened));
        }
        [NonAction]
        [HttpGet("lookups/source-of-modification")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetSourceOfModification()
        {
            return ExecuteWcfCall(() => _reportService.GetSourceOfModificationAsync(), nameof(GetSourceOfModification));
        }
        [NonAction]
        [HttpGet("lookups/report-modification-responsibility")]
        [ProducesResponseType(typeof(LookupDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetReportModificationResponsibilityDIM()
        {
            return ExecuteWcfCall(() => _reportService.GetReportModificationResponsibilityDIMAsync(), nameof(GetReportModificationResponsibilityDIM));
        }
        [NonAction]
        [HttpGet("lookups/transfered-status")]
        [ProducesResponseType(typeof(TransferStatusDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetTransferedStatusList()
        {
            return ExecuteWcfCall(() => _reportService.GetTransferedStatusListAsync(), nameof(GetTransferedStatusList));
        }



        // --- Incident/Report Endpoints (Continued) ---
        [NonAction]
        [HttpGet("incidents/{incidentId}/tickets/print-data")]
        [ProducesResponseType(typeof(TicketDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetPrintingTicketData(long incidentId)
        {
            return ExecuteWcfCall(() => _reportService.GetPrintingTicketDataAsync(incidentId), nameof(GetPrintingTicketData));
        }
        [NonAction]
        [HttpGet("rsp/activities/{activityId}/basic-details")]
        [ProducesResponseType(typeof(RspBasicDetailsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetRspReportBasicDetailsByActivityId(long activityId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetRspReportBasicDetailsByActivityIdAsync(activityId), nameof(GetRspReportBasicDetailsByActivityId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("incidents/{incidentId}/reports")]
        [ProducesResponseType(typeof(ReportDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetIncidentReport(long incidentId)
        {
            return ExecuteWcfCall(() => _reportService.GetIncidentReportAsync(incidentId), nameof(GetIncidentReport));
        }
        [NonAction]
        [HttpPost("offline")] // Save offline report
        [ProducesResponseType(typeof(SaveReportResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveOfflineIncidentReport([FromBody] OfflineReportSaveRequest request)
        {
            // Assuming a wrapper DTO for the multiple parameters
            if (!ModelState.IsValid || request?.ReportObject == null)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveOfflineIncidentReportAsync(request.ReportObject, request.ReportAmbulance, request.ReportDtoRaw), nameof(SaveOfflineIncidentReport));
        }

        // Wrapper DTO for SaveOfflineIncidentReport parameters
        public class OfflineReportSaveRequest
        {
            public ReportDTO ReportObject { get; set; }
            public ReportAmbulanceDTO ReportAmbulance { get; set; } // Assuming this DTO exists
            public string ReportDtoRaw { get; set; }
        }
        [NonAction]
        [HttpGet("can-save")]
        [ProducesResponseType(typeof(CanSaveReportResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> CanSaveReport([FromQuery] string incidentNo, [FromQuery] string reportNumber, [FromQuery] long patrolId)
        {
            return ExecuteWcfCall(() => _reportService.CanSaveReportAsync(incidentNo, reportNumber, patrolId), nameof(CanSaveReport));
        }
        [NonAction]
        [HttpPost("rsp")] // Save RSP report
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveRspIncidentReport([FromBody] RspReportDto reportObject)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveRspIncidentReportAsync(reportObject), nameof(SaveRspIncidentReport));
        }
        [NonAction]
        [HttpGet("accidents/{accidentId}/vehicles-drivers/mdt-view")]
        [ProducesResponseType(typeof(VehicleDriverModelDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetMdtViewVehicleDataByAccidentId(long accidentId)
        {
            return ExecuteWcfCall(() => _reportService.GetMdtViewVehicleDataByAccidentIdAsync(accidentId), nameof(GetMdtViewVehicleDataByAccidentId));
        }
        [NonAction]
        [HttpGet("accidents/{accidentId}/images/mdt-view")]
        [ProducesResponseType(typeof(SlideShowModelDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetMdtViewReportImagesByAccidentId(long accidentId)
        {
            return ExecuteWcfCall(() => _reportService.GetMdtViewReportImagesByAccidentIdAsync(accidentId), nameof(GetMdtViewReportImagesByAccidentId));
        }
        [NonAction]
        [HttpGet("rsp/activities/{activityId}/images")]
        [ProducesResponseType(typeof(RspImagesDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspReportImagesByActivityId(long activityId)
        {
            return ExecuteWcfCall(() => _reportService.GetRspReportImagesByActivityIdAsync(activityId), nameof(GetRspReportImagesByActivityId));
        }
        [NonAction]
        [HttpGet("rsp/activities/{activityId}/procedures")]
        [ProducesResponseType(typeof(RspProceduresDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetRspReportProceduresByActivityId(long activityId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetRspReportProceduresByActivityIdAsync(activityId), nameof(GetRspReportProceduresByActivityId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("rsp/activities/{activityId}/vehicles")]
        [ProducesResponseType(typeof(RspVehicleDataDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetRspReportVehicleDataByActivityId(long activityId)
        {
            return ExecuteWcfCall(() => _reportService.GetRspReportVehicleDataByActivityIdAsync(activityId), nameof(GetRspReportVehicleDataByActivityId));
        }
        [NonAction]
        [HttpGet("rsp/incidents/{incidentId}")]
        [ProducesResponseType(typeof(RspReportDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetRspIncidentReport(long incidentId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetRspIncidentReportAsync(incidentId), nameof(GetRspIncidentReport));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("incidents/{incidentId}/pdf")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetIncidentReportPdfByIncidentId(long incidentId)
        {
            var result = await ExecuteWcfCall(async () => await _reportService.GetIncidentReportPdfByIncidentIdAsync(incidentId), nameof(GetIncidentReportPdfByIncidentId));
            if (result is OkObjectResult okResult && okResult.Value is byte[] pdfBytes && pdfBytes.Length > 0)
            {
                return File(pdfBytes, "application/pdf", $"IncidentReport_{incidentId}.pdf");
            }
            if (result is OkObjectResult okResult2 && okResult2.Value == null) return NotFound(); // If service returns null
            if (result is OkObjectResult okResult3 && okResult3.Value is byte[] pdfBytes2 && pdfBytes2.Length == 0) return NotFound(); // If service returns empty byte array
            return result; // Return original error result if not OK
        }
        [NonAction]
        [HttpGet("{reportId}/pdf")]
        [ProducesResponseType(typeof(FileContentResult), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetIncidentReportPdfByReportId(long reportId)
        {
            var result = await ExecuteWcfCall(async () => await _reportService.GetIncidentReportPdfByReportIdAsync(reportId), nameof(GetIncidentReportPdfByReportId));
            if (result is OkObjectResult okResult && okResult.Value is byte[] pdfBytes && pdfBytes.Length > 0)
            {
                return File(pdfBytes, "application/pdf", $"Report_{reportId}.pdf");
            }
            if (result is OkObjectResult okResult2 && okResult2.Value == null) return NotFound();
            if (result is OkObjectResult okResult3 && okResult3.Value is byte[] pdfBytes2 && pdfBytes2.Length == 0) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("{reportId}/accident-details")]
        [ProducesResponseType(typeof(ReportDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetAccidentReportByReportId(long reportId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetAccidentReportByReportIdAsync(reportId), nameof(GetAccidentReportByReportId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("by-number/{reportNumber}")]
        [ProducesResponseType(typeof(ReportDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetReportDetailsByReportNumber(string reportNumber)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetReportDetailsByReportNumberAsync(reportNumber), nameof(GetReportDetailsByReportNumber));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }
        [NonAction]
        [HttpGet("{reportId}/pdf-details")] // Different endpoint from GetIncidentReportPdfByReportId
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)] // Assuming it returns DTO, not PDF bytes
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetReportPDFByReportId(long reportId)
        {
            var result = await _reportService.GetReportPDFByReportIdAsync(reportId);
            if (result!=null)
            {
                var x = await _reportTemplateService.GenerateAsync(result);
                return  Ok( x ); 

            }
            return NotFound();
        }

        [NonAction]
        [HttpGet("{reportId}/slideshow")]
        [ProducesResponseType(typeof(SlideShowModelDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetReportSlideShow(long reportId)
        {
            return ExecuteWcfCall(() => _reportService.GetReportSlideShowAsync(reportId), nameof(GetReportSlideShow));
        }

        [NonAction]
        [HttpGet("{reportId}/last-renew-request")]
        [ProducesResponseType(typeof(Tuple<int, DateTime>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetLastRenewRequestReport(long reportId)
        {
            // Tuple might not serialize well to JSON by default, consider a DTO
            return ExecuteWcfCall(() => _reportService.GetLastRenewRequestReportAsync(reportId), nameof(GetLastRenewRequestReport));
        }

        [NonAction]
        [HttpPost("save-with-approval")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveReportWithApprovalCycle([FromBody] SaveReportWithApprovalRequest request)
        {
            if (!ModelState.IsValid || request?.ModifiedReport == null || request.Request == null || request.Fields == null)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveReportWithApprovalCycleAsync(request.ModifiedReport, request.Request, request.Fields), nameof(SaveReportWithApprovalCycle));
        }

        // Wrapper DTO
        public class SaveReportWithApprovalRequest
        {
            public ReportDTO ModifiedReport { get; set; }
            public ReportRequestDto Request { get; set; }
            public FieldsToBeApprovedDTO[] Fields { get; set; }
        }

        [NonAction]
        [HttpPost("modification-list")]
        [ProducesResponseType(typeof(DifferentValues[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetModificationList([FromBody] ReportDTO modifiedReport)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.GetModificationListAsync(modifiedReport), nameof(GetModificationList));
        }

        [NonAction]
        [HttpPost("incidents/{accidentId}/upload")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> UploadIncidentReport(long accidentId)
        {
            // This likely needs more complex handling if it involves actual file uploads from the client
            // The WCF method might expect a path or trigger a process. Clarification needed.
            // For now, just calling the method.
            return ExecuteWcfCall(() => _reportService.UploadIncidentReportAsync(accidentId), nameof(UploadIncidentReport));
        }

        [NonAction]
        [HttpPost("accidents/{accidentNumber}/image-count")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveImageCountByAccidentNumber(string accidentNumber, [FromBody] ImageCountSaveRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveImageCountByAccidentNumberAsync(request.ImageCount, accidentNumber, request.ReportId), nameof(SaveImageCountByAccidentNumber));
        }

        // Wrapper DTO
        public class ImageCountSaveRequest
        {
            public int ImageCount { get; set; }
            public int ReportId { get; set; }
        }

        [NonAction]
        [HttpGet("escorting/activities/{activityId}/basic-details")]
        [ProducesResponseType(typeof(EscortingBasicDetailsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetEscortingReportBasicDetailsByActivityId(long activityId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetEscortingReportBasicDetailsByActivityIdAsync(activityId), nameof(GetEscortingReportBasicDetailsByActivityId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("escorting/activities/{activityId}/images")]
        [ProducesResponseType(typeof(EscortingImagesDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetEscortingReportImagesByActivityId(long activityId)
        {
            return ExecuteWcfCall(() => _reportService.GetEscortingReportImagesByActivityIdAsync(activityId), nameof(GetEscortingReportImagesByActivityId));
        }

        [NonAction]
        [HttpGet("tunnel/activities/{activityId}/basic-details")]
        [ProducesResponseType(typeof(TunnelBasicDetailsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTunnelReportBasicDetailsByActivityId(long activityId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetTunnelReportBasicDetailsByActivityIdAsync(activityId), nameof(GetTunnelReportBasicDetailsByActivityId));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("tunnel/activities/{activityId}/images")]
        [ProducesResponseType(typeof(TunnelImagesDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetTunnelReportImagesByActivityId(long activityId)
        {
            return ExecuteWcfCall(() => _reportService.GetTunnelReportImagesByActivityIdAsync(activityId), nameof(GetTunnelReportImagesByActivityId));
        }



        // --- Vehicle/Driver Endpoints ---

        [NonAction]
        [HttpPost("vehicle-info")]
        [ProducesResponseType(typeof(VehicleInfoResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetVehicleInfo([FromBody] VehicleInfoRequestDto requestDto)
        {
            // WARNING: Passing credentials directly in request is insecure.
            // TODO: Implement secure credential handling (e.g., fetch from config or secure store based on context)
            // For now, assuming credentials might be part of the request or need to be added.
            // Placeholder credentials - replace with secure mechanism!
            string userName = "wcf_user"; // Replace with actual username from secure source
            string password = "wcf_password"; // Replace with actual password from secure source

            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.GetVehicleInfoAsync(requestDto, userName, password), nameof(GetVehicleInfo));
        }

        [NonAction]
        [HttpPost("vehicle-info/fta")]
        [ProducesResponseType(typeof(FTAVehicleInfoResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> FTAGetVehicleInfo([FromBody] VehicleInfoRequestDto requestDto)
        {
            // WARNING: Passing credentials directly in request is insecure.
            // TODO: Implement secure credential handling
            string userName = "wcf_user"; // Replace with actual username from secure source
            string password = "wcf_password"; // Replace with actual password from secure source

            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.FTAGetVehicleInfoAsync(requestDto, userName, password), nameof(FTAGetVehicleInfo));
        }

        [NonAction]
        [HttpPost("driver-info")]
        [ProducesResponseType(typeof(TrafficProfileResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetDriverInfo([FromBody] TrafficProfileRequestDto requestDto)
        {
            // WARNING: Passing credentials directly in request is insecure.
            // TODO: Implement secure credential handling
            string userName = "wcf_user"; // Replace with actual username from secure source
            string password = "wcf_password"; // Replace with actual password from secure source

            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.GetDriverInfoAsync(requestDto, userName, password), nameof(GetDriverInfo));
        }

        [NonAction]
        [HttpPost("driver-info/fta")]
        [ProducesResponseType(typeof(TrafficProfileResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetFTATrafficProfileInfo([FromBody] TrafficProfileRequestDto requestDto)
        {
            // WARNING: Passing credentials directly in request is insecure.
            // TODO: Implement secure credential handling
            string userName = "wcf_user"; // Replace with actual username from secure source
            string password = "wcf_password"; // Replace with actual password from secure source

            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.GetFTATrafficProfileInfoAsync(requestDto, userName, password), nameof(GetFTATrafficProfileInfo));
        }

        [NonAction]
        [HttpGet("vehicles/{vehiclePlateNumber}/accident-history/last")]
        [ProducesResponseType(typeof(VehicleAccidentHistory), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetLastAccidentHistory(string vehiclePlateNumber)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetLastAccidentHistoryAsync(vehiclePlateNumber), nameof(GetLastAccidentHistory));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("persons/{personId}")]
        [ProducesResponseType(typeof(MobilePersonDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetPersonById(long personId)
        {
            var result = await ExecuteWcfCall(() => _reportService.GetPersonByIdAsync(personId), nameof(GetPersonById));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        // --- Misc Endpoints (Continued) ---

        [NonAction]
        [HttpGet("misc/google-map-credentials")]
        [ProducesResponseType(typeof(ClientCredentials), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetGoogleMapClientCredentials()
        {
            return ExecuteWcfCall(() => _reportService.GetGoogleMapClientCredentialsAsync(), nameof(GetGoogleMapClientCredentials));
        }

        [NonAction]
        [HttpGet("misc/google-map-api-key")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetGoogleMapAPIKey()
        {
            return ExecuteWcfCall(() => _reportService.GetGoogleMapAPIKeyAsync(), nameof(GetGoogleMapAPIKey));
        }

        [NonAction]
        [HttpPost("misc/send-survey")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendSurveyMessage([FromBody] SurveyMessageRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // WCF method is void, so helper will return Ok(null) on success
            return ExecuteWcfCall<object>(async () =>
            {
                await _reportService.SendSurveyMessageAsync(request.ReportNumber, request.MobileNumber, request.PlateNumber);
                return null; // Explicitly return null since the WCF method is void
            }, nameof(SendSurveyMessage));
        }

        // Wrapper DTO
        public class SurveyMessageRequest
        {
            public string ReportNumber { get; set; }
            public string MobileNumber { get; set; }
            public string PlateNumber { get; set; }
        }

        [NonAction]
        [HttpPost("misc/mobile-request-transaction")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveMobileRequestTransaction([FromBody] MobileRequestTransactionRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SaveMobileRequestTransactionAsync(request.StatusId, request.RequestNumber, request.PersonId, request.CreationDate), nameof(SaveMobileRequestTransaction));
        }

        // Wrapper DTO
        public class MobileRequestTransactionRequest
        {
            public int StatusId { get; set; }
            public long RequestNumber { get; set; }
            public long PersonId { get; set; }
            public DateTime CreationDate { get; set; }
        }

        [NonAction]
        [HttpGet("misc/translations")]
        [ProducesResponseType(typeof(TranslationDto[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetTranslation()
        {
            return ExecuteWcfCall(() => _reportService.GetTranslationAsync(), nameof(GetTranslation));
        }

        [NonAction]
        [HttpGet("misc/is-valid-for-display")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> IsValidReportForDisplay([FromQuery] string reportnumber, [FromQuery] int numberOfValidReportDays, [FromQuery] int numberOfValidRenewalDays)
        {
            return ExecuteWcfCall(() => _reportService.IsValidReportForDisplayAsync(reportnumber, numberOfValidReportDays, numberOfValidRenewalDays), nameof(IsValidReportForDisplay));
        }

        [NonAction]
        [HttpPost("misc/send-sms/all-tickets")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendReportSMSForAllTickets([FromBody] ReportDTO reportDto)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Explicitly specify the type argument for ExecuteWcfCall
            return ExecuteWcfCall<object>(async () =>
            {
                await _reportService.SendReportSMSForAllTicketsAsync(reportDto);
                return null; // Explicitly return null since the WCF method is void
            }, nameof(SendReportSMSForAllTickets));
        }

        [NonAction]
        [HttpPost("misc/send-sms/one-ticket")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendReportSMSForOneTickets([FromBody] SendOneTicketSmsRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Explicitly specify the type argument for ExecuteWcfCall
            return ExecuteWcfCall(async () =>
            {
                await _reportService.SendReportSMSForOneTicketsAsync(request.Model, request.ReportNumber);
                return (object)null; // Explicitly return null since the WCF method is void
            }, nameof(SendReportSMSForOneTickets));
        }

        // Wrapper DTO
        public class SendOneTicketSmsRequest
        {
            public VehicleDriverModelDTO Model { get; set; }
            public string ReportNumber { get; set; }
        }

        [NonAction]
        [HttpPost("misc/send-sms/private-ticket")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendReportSMSForPrivateTicketsWithLang([FromBody] SendPrivateTicketSmsRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SendReportSMSForPrivateTicketsWithLangAsync(request.Code, request.MobileNumber, request.ReportNumber, request.Lang), nameof(SendReportSMSForPrivateTicketsWithLang));
        }

        // Wrapper DTO
        public class SendPrivateTicketSmsRequest
        {
            public string Code { get; set; }
            public string MobileNumber { get; set; }
            public string ReportNumber { get; set; }
            public string Lang { get; set; }
        }

        [NonAction]
        [HttpPost("misc/send-sms/one-ticket-lang")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendReportSMSForOneTicketsWithLang([FromBody] SendOneTicketLangSmsRequest request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            return ExecuteWcfCall(() => _reportService.SendReportSMSForOneTicketsWithLangAsync(request.Model, request.ReportNumber, request.Lang), nameof(SendReportSMSForOneTicketsWithLang));
        }

        // Wrapper DTO
        public class SendOneTicketLangSmsRequest
        {
            public VehicleDriverModelDTO Model { get; set; }
            public string ReportNumber { get; set; }
            public string Lang { get; set; }
        }

        [NonAction]
        [HttpPost("misc/notify-applicant-extended-service/{reportId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SendApplicantExtendedServiceNotificationMessage(long reportId)
        {
            // Explicitly specify the type argument as 'object' since the WCF method is void
            return ExecuteWcfCall<object>(async () =>
            {
                await _reportService.SendApplicantExtendedServiceNotificationMessageAsync(reportId);
                return null; // Explicitly return null since the WCF method is void
            }, nameof(SendApplicantExtendedServiceNotificationMessage));
        }

        [NonAction]
        [HttpGet("misc/allowed-inquiry-clicks")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> AllowedInquiryClick()
        {
            return ExecuteWcfCall(() => _reportService.AllowedInquiryClickAsync(), nameof(AllowedInquiryClick));
        }

        // --- Request/Transfer/Confiscation/Traffic Code Endpoints ---
        // Note: These endpoints likely require authorization checks based on user roles/areas

        [NonAction]
        [HttpPost("requests/search")]
        [ProducesResponseType(typeof(RequestListDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetRequestsList([FromBody] ReportRequestSearchCriteriaDTO searchCriteria, [FromQuery] bool isExternal = false, [FromQuery] bool myTask = false)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            // Get user context for authorization/filtering
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized(); // Should not happen if [Authorize] works

            // Convert Guid[] roles to Guid[] if needed (assuming currentUser.Roles is Guid[])
            // Convert List<long> areas to long[]
            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>(); // Assuming Roles are Guid[]

            return await ExecuteWcfCall(() => _reportService.GetRequestsListAsync(searchCriteria, permittedAreas, roleIds, isExternal, myTask), nameof(GetRequestsList));
        }

        [NonAction]
        [HttpPost("requests/closed/search")]
        [ProducesResponseType(typeof(RequestListDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetClosedRequestsList([FromBody] ReportRequestSearchCriteriaDTO searchCriteria, [FromQuery] bool isExternal = false)
        {
             if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();

            return await ExecuteWcfCall(() => _reportService.GetClosedRequestsListAsync(searchCriteria, permittedAreas, roleIds, isExternal), nameof(GetClosedRequestsList));
        }

        [NonAction]
        [HttpGet("requests/{requestId}")]
        [ProducesResponseType(typeof(ReportRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetRequestById(long requestId)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();
            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();

            var result = await ExecuteWcfCall(() => _reportService.GetRequestByIdAsync(requestId, roleIds), nameof(GetRequestById));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("requests/transfered/{requestId}")]
        [ProducesResponseType(typeof(ReportRequestDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTransferedRequestById(long requestId)
        {
            // This might need role/area checks too, depending on requirements
            var result = await ExecuteWcfCall(() => _reportService.GetTransferedRequestByIdAsync(requestId), nameof(GetTransferedRequestById));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpPost("reports/under-process")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> UnderProcessReport([FromBody] ReportTransferingDTO report)
        {
             if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.UnderProcessReportAsync(report), nameof(UnderProcessReport));
        }

        [NonAction]
        [HttpPost("requests/transfered/search")]
        [ProducesResponseType(typeof(RequestListDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTransferedRequestsList([FromBody] ReportRequestSearchCriteriaDTO searchCriteria)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            Guid[] roleIds = currentUser.Roles?.ToArray() ?? Array.Empty<Guid>();
            long userId = currentUser.PersonId; // Assuming UserId is long, adjust if Guid

            return await ExecuteWcfCall(() => _reportService.GetTransferedRequestsListAsync(searchCriteria, permittedAreas, roleIds, userId), nameof(GetTransferedRequestsList));
        }

        [NonAction]
        [HttpPost("requests")] // Save Request
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveRequest([FromBody] ReportRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.SaveRequestAsync(request), nameof(SaveRequest));
        }

        [NonAction]
        [HttpPost("requests/transfer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> TransferRequest([FromBody] ReportRequestDto request)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.TransferRequestAsync(request), nameof(TransferRequest));
        }

        [NonAction]
        [HttpGet("requests/{requestId}/can-transfer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> CanTransferRequest(long requestId)
        {
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.CanTransferRequestAsync(requestId), nameof(CanTransferRequest));
        }

        [NonAction]
        [HttpPost("reports/transfer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> TransferReport([FromBody] ReportTransferingDTO convertedReport)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.TransferReportAsync(convertedReport), nameof(TransferReport));
        }

        [NonAction]
        [HttpPost("reports/transfering/close")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> CloseReportTransfering([FromBody] ReportTransferingDTO convertedReport)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.CloseReportTransferingAsync(convertedReport), nameof(CloseReportTransfering));
        }

        [NonAction]
        [HttpPost("reports/transfered/search")]
        [ProducesResponseType(typeof(ReportTransferingDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTransferedReportList([FromBody] ReportTransferingSearchCriteriaDTO search, [FromQuery] int? transferStatusId, [FromQuery] int skip = 0, [FromQuery] int take = 20)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            long[] orgs = currentUser.Organizations?.ToArray() ?? Array.Empty<long>(); // Assuming Orgs are long[]

            return await ExecuteWcfCall(() => _reportService.GetTransferedReportListAsync(search, permittedAreas, orgs, transferStatusId, skip, take), nameof(GetTransferedReportList));
        }

        [NonAction]
        [HttpPost("reports/transfered/status/search")]
        [ProducesResponseType(typeof(ReportTransferingDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTransferedReportStatusList([FromBody] ReportTransferingSearchCriteriaDTO search, [FromQuery] int skip = 0, [FromQuery] int take = 20)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            long[] orgs = currentUser.Organizations?.ToArray() ?? Array.Empty<long>();

            return await ExecuteWcfCall(() => _reportService.GetTransferedReportStatusListAsync(search, permittedAreas, orgs, skip, take), nameof(GetTransferedReportStatusList));
        }

        [NonAction]
        [HttpGet("reports/{reportId}/is-transfered")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> CheckReportTransfered(int reportId)
        {
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.CheckReportTransferedAsync(reportId), nameof(CheckReportTransfered));
        }

        [NonAction]
        [HttpPost("reports/transfered/closed/search")]
        [ProducesResponseType(typeof(ReportTransferingDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetClosedTransferedReportList([FromBody] ReportTransferingSearchCriteriaDTO search, [FromQuery] int skip = 0, [FromQuery] int take = 20)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();
            long[] orgs = currentUser.Organizations?.ToArray() ?? Array.Empty<long>();

            return await ExecuteWcfCall(() => _reportService.GetClosedTransferedReportListAsync(search, permittedAreas, orgs, skip, take), nameof(GetClosedTransferedReportList));
        }

        [NonAction]
        [HttpGet("reports/transfered/{reportId}")]
        [ProducesResponseType(typeof(ReportTransferingDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTransferedReport(int reportId)
        {
            // Add authorization checks if needed
            var result = await ExecuteWcfCall(() => _reportService.GetTransferedReportAsync(reportId), nameof(GetTransferedReport));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpGet("reports/transfered/{reportId}/log")]
        [ProducesResponseType(typeof(TransferedReportLog[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetTransferedReportLog(int reportId)
        {
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.GetTransferedReportLogAsync(reportId), nameof(GetTransferedReportLog));
        }

        [NonAction]
        [HttpPost("confiscations/search")]
        [ProducesResponseType(typeof(ConfiscationDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetConfiscationList([FromBody] ConfiscationListSearchCriteriaDTO search)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();

            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();

            return await ExecuteWcfCall(() => _reportService.GetConfiscationListAsync(search, permittedAreas), nameof(GetConfiscationList));
        }

        [NonAction]
        [HttpGet("confiscations/drivers/{driverDataId}")]
        [ProducesResponseType(typeof(ConfiscationDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetConfiscationById(long driverDataId)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();
            long[] permittedAreas = currentUser.Areas?.ToArray() ?? Array.Empty<long>();

            var result = await ExecuteWcfCall(() => _reportService.GetConfiscationByIdAsync(permittedAreas, driverDataId), nameof(GetConfiscationById));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpPut("confiscations")] // Use PUT for update
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveConfiscationNewStatusAndComment([FromBody] ConfiscationDTO confiscation)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.SaveConfiscationNewStatusAndCommentAsync(confiscation), nameof(SaveConfiscationNewStatusAndComment));
        }

        [NonAction]
        [HttpPost("traffic-codes/search")]
        [ProducesResponseType(typeof(TrafficCodeDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetTrafficCodeList([FromBody] TrafficCodeListSearchCriteriaDTO search, [FromQuery] int take = 20, [FromQuery] int skip = 0)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.GetTrafficCodeListAsync(search, take, skip), nameof(GetTrafficCodeList));
        }

        [NonAction]
        [HttpGet("traffic-codes/{trafficCodeId}")]
        [ProducesResponseType(typeof(TrafficCodeDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetTrafficCodeById(long trafficCodeId)
        {
            // Add authorization checks if needed
            var result = await ExecuteWcfCall(() => _reportService.GetTrafficCodeByIdAsync(trafficCodeId), nameof(GetTrafficCodeById));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

        [NonAction]
        [HttpPost("traffic-codes")] // Save new or update existing
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> SaveTrafficCode([FromBody] TrafficCodeDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.SaveTrafficCodeAsync(dto), nameof(SaveTrafficCode));
        }

        [NonAction]
        [HttpDelete("traffic-codes/{trafficCodeId}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> DeleteTrafficCode(long trafficCodeId)
        {
            var currentUser = await _currentUserService.GetCurrentUserAsync();
            if (currentUser == null) return Unauthorized();
            long userId = currentUser.PersonId; // Assuming UserId is long

            // Add authorization checks if needed
            return await ExecuteWcfCall(() => _reportService.DeleteTrafficCodeAsync(trafficCodeId, userId), nameof(DeleteTrafficCode));
        }

        // --- TS Incident List / Mobile Request Endpoints ---

        [NonAction]
        [HttpPost("ts-incidents/search")]
        [ProducesResponseType(typeof(TSIncidentListDTO[]), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public Task<IActionResult> GetIncidentList([FromBody] IncidentSearchDto search)
        {
            if (!ModelState.IsValid)
            {
                return Task.FromResult<IActionResult>(BadRequest(ModelState));
            }
            // Add authorization checks if needed
            return ExecuteWcfCall(() => _reportService.GetIncidentListAsync(search), nameof(GetIncidentList));
        }

        [NonAction]
        [HttpGet("mobile-requests/{mobileRequestId}/detailed")]
        [ProducesResponseType(typeof(MobileRequestDetailedDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status502BadGateway)]
        [ProducesResponseType(StatusCodes.Status504GatewayTimeout)]
        public async Task<IActionResult> GetDetailedMobileRequest(long mobileRequestId)
        {
            // Add authorization checks if needed
            var result = await ExecuteWcfCall(() => _reportService.GetDetailedMobileRequestAsync(mobileRequestId), nameof(GetDetailedMobileRequest));
            if (result is OkObjectResult okResult && okResult.Value == null) return NotFound();
            return result;
        }

    }
}

