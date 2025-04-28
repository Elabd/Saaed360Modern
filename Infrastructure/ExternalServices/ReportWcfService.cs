// Auto‑generated convenience wrapper for WCF proxy – singleton‑friendly
// ---------------------------------------------------------------
// Usage:
//     builder.Services.AddSingleton<IReportWcfService, ReportWcfService>();
// ---------------------------------------------------------------

using System.ServiceModel;
using Application.Abstractions;
using Saaed360Modern.Contracts.Wcf;
using Saaed360Modern.Infrastructure.ExternalServices.MDTReportServiceRef;

namespace Saaed360Modern.Infrastructure.ExternalServices
{
    /// <inheritdoc/>
    public class ReportWcfService : IReportWcfService
    {
        private readonly ReportServiceClient _client;

        public ReportWcfService()
        {
            var binding = new BasicHttpBinding
            {
                Security = new BasicHttpSecurity { Mode = BasicHttpSecurityMode.Transport },
                MaxReceivedMessageSize = 1024 * 1024 * 20 // 20 MB – tune as needed
            };

            var endpoint = new EndpointAddress("https://saaed360.saaed.ae/Saaed360MDTWCF/ReportService.svc");
            _client = new ReportServiceClient(binding, endpoint);
        }

        // -------------  LOOKUP  -------------
        public Task<LookupDto[]> GetRspAffectedLaneAsync() => _client.GetRspAffectedLaneAsync();
        public Task<LookupDto[]> GetRspVehicleDamagedTypeAsync() => _client.GetRspVehicleDamagedTypeAsync();
        public Task<LookupDto[]> GetRspFieldsFactorAsync() => _client.GetRspFieldsFactorAsync();
        public Task<LookupDto[]> GetRspEventTypeAsync() => _client.GetRspEventTypeAsync();
        public Task<LookupDto[]> GetRspProceduresAsync() => _client.GetRspProceduresAsync();
        public Task<LookupDto[]> GetRspTrafficStatusAsync() => _client.GetRspTrafficStatusAsync();
        public Task<LookupDto[]> GetRspDamagedLevelAsync() => _client.GetRspDamagedLevelAsync();
        public Task<LookupDto[]> GetRspIncidentLaneAsync() => _client.GetRspIncidentLaneAsync();
        public Task<LookupDto[]> GetAllCitiesAsync() => _client.GetAllCitiesAsync();
        public Task<LookupDto[]> GetEmiratesAsync() => _client.GetEmiratesAsync();
        public Task<LookupDto[]> GetAreaBySelectedEmirateIdAsync(long emirateId) => _client.GetAreaBySelectedEmirateIdAsync(emirateId);
        public Task<LookupDto[]> GetSectorBySelectedAreaIdAsync(long areaId) => _client.GetSectorBySelectedAreaIdAsync(areaId);
        public Task<LookupDto[]> GetStreetBySectorIdAsync(long sectorId) => _client.GetStreetBySectorIdAsync(sectorId);
        public Task<LookupDto[]> GetCrossStreetByStreetIdAsync(long streetId) => _client.GetCrossStreetByStreetIdAsync(streetId);

        // -------------  INCIDENT / REPORT  -------------
        public Task<TicketDTO[]> GetPrintingTicketDataAsync(long incidentId) => _client.GetPrintingTicketDataAsync(incidentId);
        public Task<RspBasicDetailsDto> GetRspReportBasicDetailsByActivityIdAsync(long activityId) => _client.GetRspReportBasicDetailsByActivityIdAsync(activityId);
        public Task<ReportDTO> GetReportByReportIdAsync(long reportId) => _client.GetReportByReportIdAsync(reportId);
        public Task<ReportDTO[]> GetIncidentReportAsync(long incidentId) => _client.GetIncidentReportAsync(incidentId);
        public Task<int> SaveIncidentReportAsync(ReportDTO reportObject) => _client.SaveIncidentReportAsync(reportObject);
        public Task<SaveReportResponse> SaveOfflineIncidentReportAsync(ReportDTO reportObject, ReportAmbulanceDTO reportAmbulance, string reportDtoRaw) => _client.SaveOfflineIncidentReportAsync(reportObject, reportAmbulance, reportDtoRaw);
        public Task<CanSaveReportResponse> CanSaveReportAsync(string incidentNo, string reportNumber, long patrolId) => _client.CanSaveReportAsync(incidentNo, reportNumber, patrolId);
        public Task<int> SaveRspIncidentReportAsync(RspReportDto reportObject) => _client.SaveRspIncidentReportAsync(reportObject);

        // -------------  VEHICLE / DRIVER  -------------
        public Task<VehicleInfoResponseDto> GetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string username, string password) => _client.GetVehicleInfoAsync(requestDto, username, password);
        public Task<FTAVehicleInfoResponseDto> FTAGetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string username, string password) => _client.FTAGetVehicleInfoAsync(requestDto, username, password);
        public Task<TrafficProfileResponseDto> GetDriverInfoAsync(TrafficProfileRequestDto requestDto, string username, string password) => _client.GetDriverInfoAsync(requestDto, username, password);
        public Task<TrafficProfileResponseDto> GetFTATrafficProfileInfoAsync(TrafficProfileRequestDto requestDto, string username, string password) => _client.GetFTATrafficProfileInfoAsync(requestDto, username, password);
        public Task<VehicleAccidentHistory> GetLastAccidentHistoryAsync(string vehiclePlateNumber) => _client.GetLastAccidentHistoryAsync(vehiclePlateNumber);

        // -------------  MISC  -------------
        public Task<string> GetServerDateAsync() => _client.GetServerDateAsync();
        public Task<ClientCredentials> GetGoogleMapClientCredentialsAsync() => _client.GetGoogleMapClientCredentialsAsync();
        public Task<string> GetGoogleMapAPIKeyAsync() => _client.GetGoogleMapAPIKeyAsync();

        // --------------------  REQUESTS  --------------------
        public Task<RequestListDTO[]> GetRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal, bool myTask)
            => _client.GetRequestsListAsync(searchCriteria, permittedAreas, roleId, isExternal, myTask);

        public Task<RequestListDTO[]> GetClosedRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal)
            => _client.GetClosedRequestsListAsync(searchCriteria, permittedAreas, roleId, isExternal);

        public Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleId)
            => _client.GetRequestByIdAsync(requestId, roleId);

        public Task<ReportRequestDto> GetTransferedRequestByIdAsync(long requestId)
            => _client.GetTransferedRequestByIdAsync(requestId);

        // ------------------------------------------------------------
        // NOTE: Only the most frequently‑used operations are included
        // here for brevity.  You can copy‑&‑paste any additional calls
        // from Reference.cs following the same one‑liner pattern
        //     public Task<ReturnType> MethodAsync(params) => _client.MethodAsync(params);
        // ------------------------------------------------------------
    }
}
