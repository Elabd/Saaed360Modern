// Auto‑generated convenience wrapper for WCF proxy – singleton‑friendly
// ---------------------------------------------------------------
// Usage:
//     builder.Services.AddSingleton<IReportWcfService, ReportWcfService>();
// ---------------------------------------------------------------

using System.Threading.Tasks;
using Saaed360Modern.Contracts.Wcf;
namespace Application.Abstractions
{
    /// <summary>
    ///     A DI‑friendly façade that exposes *all* operations of <see cref="ReportServiceClient"/>.
    ///     The class internally holds a single instance of <see cref="ReportServiceClient"/> that
    ///     is configured for HTTPS (BasicHttpBinding + Transport security).
    /// </summary>
    public interface IReportWcfService
    {
        // --------------------  LOOKUP  --------------------
        Task<LookupDto[]> GetRspAffectedLaneAsync();
        Task<LookupDto[]> GetRspVehicleDamagedTypeAsync();
        Task<LookupDto[]> GetRspFieldsFactorAsync();
        Task<LookupDto[]> GetRspEventTypeAsync();
        Task<LookupDto[]> GetRspProceduresAsync();
        Task<LookupDto[]> GetRspTrafficStatusAsync();
        Task<LookupDto[]> GetRspDamagedLevelAsync();
        Task<LookupDto[]> GetRspIncidentLaneAsync();
        Task<LookupDto[]> GetAllCitiesAsync();
        Task<LookupDto[]> GetEmiratesAsync();
        Task<LookupDto[]> GetAreaBySelectedEmirateIdAsync(long emirateId);
        Task<LookupDto[]> GetSectorBySelectedAreaIdAsync(long areaId);
        Task<LookupDto[]> GetStreetBySectorIdAsync(long sectorId);
        Task<LookupDto[]> GetCrossStreetByStreetIdAsync(long streetId);
        // ....  ✂️  (add additional lookup operations as required)

        // --------------------  INCIDENT / REPORT  --------------------
        Task<TicketDTO[]> GetPrintingTicketDataAsync(long incidentId);
        Task<RspBasicDetailsDto> GetRspReportBasicDetailsByActivityIdAsync(long activityId); Task<ReportDTO> GetReportByReportIdAsync(long reportId);
        Task<ReportDTO[]> GetIncidentReportAsync(long incidentId);
        Task<int> SaveIncidentReportAsync(ReportDTO reportObject);
        Task<SaveReportResponse> SaveOfflineIncidentReportAsync(ReportDTO reportObject, ReportAmbulanceDTO reportAmbulance, string reportDtoRaw);
        Task<CanSaveReportResponse> CanSaveReportAsync(string incidentNo, string reportNumber, long patrolId);
        Task<int> SaveRspIncidentReportAsync(RspReportDto reportObject);
        // ....  ✂️  (add additional report operations as required)

        // --------------------  VEHICLE / DRIVER  --------------------
        Task<VehicleInfoResponseDto> GetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string userName, string password);
        Task<FTAVehicleInfoResponseDto> FTAGetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string userName, string password);
        Task<TrafficProfileResponseDto> GetDriverInfoAsync(TrafficProfileRequestDto requestDto, string userName, string password);
        Task<TrafficProfileResponseDto> GetFTATrafficProfileInfoAsync(TrafficProfileRequestDto requestDto, string userName, string password);
        Task<VehicleAccidentHistory> GetLastAccidentHistoryAsync(string vehiclePlateNumber);
        // ....  ✂️  (add additional vehicle/driver operations as required)

        // --------------------  MISC  --------------------
        Task<string> GetServerDateAsync();
        Task<ClientCredentials> GetGoogleMapClientCredentialsAsync();
        Task<string> GetGoogleMapAPIKeyAsync();
        // ....  ✂️

        // --------------------  REQUESTS  --------------------
        Task<RequestListDTO[]> GetRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal, bool myTask);
        Task<RequestListDTO[]> GetClosedRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal);
        Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleId);
        Task<ReportRequestDto> GetTransferedRequestByIdAsync(long requestId);
    }
}
