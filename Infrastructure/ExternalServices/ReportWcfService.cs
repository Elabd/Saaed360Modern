// Auto‑generated convenience wrapper for WCF proxy – singleton‑friendly
// ---------------------------------------------------------------
// Usage:
//     builder.Services.AddSingleton<IReportWcfService, ReportWcfService>();
// ---------------------------------------------------------------

using System;
using System.ServiceModel;
using System.Threading.Tasks;
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

            // TODO: Read endpoint address from configuration
            var endpoint = new EndpointAddress("https://saaed360test.saaed.ae/Saaed360MDTWCF/ReportService.svc");
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
        public Task<LookupDto> GetServiceCenterByEmiratesIdAsync(long emiratesId) => _client.GetServiceCenterByEmiratesIdAsync(emiratesId);
        public Task<LookupDto[]> GetCityBySelectedEmirateIdAsync(long emirateId) => _client.GetCityBySelectedEmirateIdAsync(emirateId);
        public Task<LookupDto[]> GetAreaByCityIdAsync(long CityId) => _client.GetAreaByCityIdAsync(CityId);
        public Task<LookupDto[]> GetAllAreasAsync() => _client.GetAllAreasAsync();
        public Task<LookupDto[]> GetSectorByAreaIdAsync(long AreaId) => _client.GetSectorByAreaIdAsync(AreaId);
        public Task<LookupDto[]> GetAllSectorsAsync() => _client.GetAllSectorsAsync();
        public Task<LookupDto[]> GetAllStreetsAsync() => _client.GetAllStreetsAsync();
        public Task<LookupDto[]> GetAllCrossStreetsAsync() => _client.GetAllCrossStreetsAsync();
        public Task<LookupDto[]> GetStreetBySelectedAreaIdAsync(long areaId) => _client.GetStreetBySelectedAreaIdAsync(areaId);
        public Task<LookupDto[]> GetCrossingStreetBySelectedAreaIdAsync(long areaId) => _client.GetCrossingStreetBySelectedAreaIdAsync(areaId);
        public Task<LookupDto[]> GetReportTypeValuesAsync(System.Nullable<int> statusid) => _client.GetReportTypeValuesAsync(statusid);
        public Task<LookupDto[]> GetListOfWeatherAsync() => _client.GetListOfWeatherAsync();
        public Task<LookupDto[]> GetListOfRoadSurfaceAsync() => _client.GetListOfRoadSurfaceAsync();
        public Task<LookupDto[]> GetListOfRoadSpeedAsync() => _client.GetListOfRoadSpeedAsync();
        public Task<LookupDto[]> GetListOfIntersectionsAsync() => _client.GetListOfIntersectionsAsync();
        public Task<LookupDto[]> GetListOfAccidentTypesAsync() => _client.GetListOfAccidentTypesAsync();
        public Task<LookupDto[]> GetListOfNationalityAsync() => _client.GetListOfNationalityAsync();
        public Task<LookupDto[]> GetListOfInjuryLevelAsync() => _client.GetListOfInjuryLevelAsync();
        public Task<LookupDto[]> GetListOfInjuryTypeAsync() => _client.GetListOfInjuryTypeAsync();
        public Task<LookupDto[]> GetListOfOrganisationAsync() => _client.GetListOfOrganisationAsync();
        public Task<LookupDto[]> GetPublicDamagePartAsync() => _client.GetPublicDamagePartAsync();
        public Task<LookupDto[]> GetPrivateDamagePartAsync() => _client.GetPrivateDamagePartAsync();
        public Task<LookupDto[]> GetListOfObjectsBySelectedOrganisationAsync(long organisationId) => _client.GetListOfObjectsBySelectedOrganisationAsync(organisationId);
        public Task<LookupDto[]> GetPlateSourceByPlateTypeId1Async(System.Nullable<long> plateColor, System.Nullable<long> PlateCategory, System.Nullable<long> plateTypeId) => _client.GetPlateSourceByPlateTypeId1Async(plateColor, PlateCategory, plateTypeId);
        public Task<LookupDto[]> GetPlateSourceByPlateTypeIdAsync(System.Nullable<long> plateTypeId) => _client.GetPlateSourceByPlateTypeIdAsync(plateTypeId);
        public Task<LookupDto[]> GetPlateSourceByListofPlateTypeIdsAsync(long[] plateTypeIds) => _client.GetPlateSourceByListofPlateTypeIdsAsync(plateTypeIds);
        public Task<LookupDto[]> GetPlateClassByPlateColorIdAsync(System.Nullable<long> plateColorId) => _client.GetPlateClassByPlateColorIdAsync(plateColorId);
        public Task<LookupDto[]> GetPlateClassByListofPlateColorIdAsync(long[] plateColorIds) => _client.GetPlateClassByListofPlateColorIdAsync(plateColorIds);
        public Task<LookupDto[]> GetPlateColorAsync() => _client.GetPlateColorAsync();
        public Task<LookupDto[]> GetPlateTypeByPlateClassId1Async(System.Nullable<long> plateClassId, System.Nullable<long> plateColorId) => _client.GetPlateTypeByPlateClassId1Async(plateClassId, plateColorId);
        public Task<LookupDto[]> GetPlateTypeByPlateClassIdAsync(System.Nullable<long> plateClassId) => _client.GetPlateTypeByPlateClassIdAsync(plateClassId);
        public Task<LookupDto[]> GetPlateTypeByListofPlateClassIdsAsync(long[] plateClassIds) => _client.GetPlateTypeByListofPlateClassIdsAsync(plateClassIds);
        public Task<LookupDto[]> GetListOfVehicleBrandsAsync() => _client.GetListOfVehicleBrandsAsync();
        public Task<LookupDto[]> GetListOfVehicleModelBySelectedVehicleBrandAsync(int vehicleBrandId) => _client.GetListOfVehicleModelBySelectedVehicleBrandAsync(vehicleBrandId);
        public Task<LookupDto[]> GetListOfVehicleTypeBySelectedVehicleModelAsync(System.Nullable<int> vehicleModelId) => _client.GetListOfVehicleTypeBySelectedVehicleModelAsync(vehicleModelId);
        public Task<LookupDto[]> GetListOfVehicleCategoryBySelectedVehicleTypeAsync(int vehicleTypeId) => _client.GetListOfVehicleCategoryBySelectedVehicleTypeAsync(vehicleTypeId);
        public Task<LookupDto[]> GetListOfVehicleModelBySelectedVehicleBrandsAsync(int[] vehicleBrandId) => _client.GetListOfVehicleModelBySelectedVehicleBrandsAsync(vehicleBrandId);
        public Task<LookupDto[]> GetListOfVehicleTypesAsync(System.Nullable<int>[] vehicleModelId) => _client.GetListOfVehicleTypesAsync(vehicleModelId);
        public Task<LookupDto[]> GetListOfVehicleCategoryBySelectedVehicleTypesAsync(System.Nullable<int>[] vehicleTypeId) => _client.GetListOfVehicleCategoryBySelectedVehicleTypesAsync(vehicleTypeId);
        public Task<LookupDto[]> GetListOfManufatureYearsAsync() => _client.GetListOfManufatureYearsAsync();
        public Task<LookupDto> GetManufactureYearByNameAsync(string year) => _client.GetManufactureYearByNameAsync(year);
        public Task<LookupDto[]> GetListOfCountryOfOriginsAsync() => _client.GetListOfCountryOfOriginsAsync();
        public Task<LookupDto> GetOriginCountryByCodeAsync(string Code) => _client.GetOriginCountryByCodeAsync(Code);
        public Task<LookupDto[]> GetAllReasonOfAccidentsAsync() => _client.GetAllReasonOfAccidentsAsync();
        public Task<LookupDto[]> GetListOfVehileColorsAsync() => _client.GetListOfVehileColorsAsync();
        public Task<LookupDto[]> GetListOfInsuranceCompanyAsync() => _client.GetListOfInsuranceCompanyAsync();
        public Task<LookupDto[]> GetListOfInsuranceTypesAsync() => _client.GetListOfInsuranceTypesAsync();
        public Task<LookupDto[]> GetListOfGlassColorsAsync() => _client.GetListOfGlassColorsAsync();
        public Task<LookupDto[]> GetListOfCollisionPointsAsync() => _client.GetListOfCollisionPointsAsync();
        public Task<LookupDto[]> GetListOfChemicalsAsync() => _client.GetListOfChemicalsAsync();
        public Task<LookupDto[]> GetListOfVehicleStateAsync() => _client.GetListOfVehicleStateAsync();
        public Task<LookupDto[]> GetListOfReasonOfAccidentsAsync() => _client.GetListOfReasonOfAccidentsAsync();
        public Task<LookupDto[]> GetListOfLicenseSourceAsync() => _client.GetListOfLicenseSourceAsync();
        public Task<LookupDto[]> GetListOfLicenseCategoryAsync() => _client.GetListOfLicenseCategoryAsync();
        public Task<LookupDto[]> GetListOfGenderAsync() => _client.GetListOfGenderAsync();
        public Task<LookupDto[]> GetListOfCareerAsync() => _client.GetListOfCareerAsync();
        public Task<LookupDto[]> GetListOfEducationLevelAsync() => _client.GetListOfEducationLevelAsync();
        public Task<LookupDto[]> GetListOfEscapedStatusAsync() => _client.GetListOfEscapedStatusAsync();
        public Task<LookupDto[]> GetListOfDriverStatusAsync() => _client.GetListOfDriverStatusAsync();
        public Task<LookupDto[]> GetListOfDriverDrinkingStatusAsync() => _client.GetListOfDriverDrinkingStatusAsync();
        public Task<LookupDto[]> GetListOfConfiscationsDocumentTypesAsync() => _client.GetListOfConfiscationsDocumentTypesAsync();
        public Task<LookupDto[]> GetAllConfiscationStatusAsync() => _client.GetAllConfiscationStatusAsync();
        public Task<LookupDto[]> GetListOfConfiscationsLocationsAsync() => _client.GetListOfConfiscationsLocationsAsync();
        public Task<LookupDto[]> GetReportEmirateAsync() => _client.GetReportEmirateAsync();
        public Task<LookupDto[]> GetHowAccidentHappenedAsync() => _client.GetHowAccidentHappenedAsync();
        public Task<LookupDto[]> GetSourceOfModificationAsync() => _client.GetSourceOfModificationAsync();
        public Task<LookupDto[]> GetReportModificationResponsibilityDIMAsync() => _client.GetReportModificationResponsibilityDIMAsync();
        public Task<TransferStatusDTO[]> GetTransferedStatusListAsync() => _client.GetTransferedStatusListAsync();

        // -------------  INCIDENT / REPORT  -------------
        public Task<TicketDTO[]> GetPrintingTicketDataAsync(long incidentId) => _client.GetPrintingTicketDataAsync(incidentId);
        public Task<RspBasicDetailsDto> GetRspReportBasicDetailsByActivityIdAsync(long activityId) => _client.GetRspReportBasicDetailsByActivityIdAsync(activityId);
        public Task<ReportDTO> GetReportByReportIdAsync(long reportId) => _client.GetReportByReportIdAsync(reportId);
        public Task<ReportDTO[]> GetIncidentReportAsync(long incidentId) => _client.GetIncidentReportAsync(incidentId);
        public Task<int> SaveIncidentReportAsync(ReportDTO reportObject) => _client.SaveIncidentReportAsync(reportObject);
        public Task<SaveReportResponse> SaveOfflineIncidentReportAsync(ReportDTO reportObject, ReportAmbulanceDTO reportAmbulance, string reportDtoRaw) => _client.SaveOfflineIncidentReportAsync(reportObject, reportAmbulance, reportDtoRaw);
        public Task<CanSaveReportResponse> CanSaveReportAsync(string incidentNo, string reportNumber, long patrolId) => _client.CanSaveReportAsync(incidentNo, reportNumber, patrolId);
        public Task<int> SaveRspIncidentReportAsync(RspReportDto reportObject) => _client.SaveRspIncidentReportAsync(reportObject);
        public Task<VehicleDriverModelDTO[]> GetMdtViewVehicleDataByAccidentIdAsync(long accidentId) => _client.GetMdtViewVehicleDataByAccidentIdAsync(accidentId);
        public Task<SlideShowModelDTO[]> GetMdtViewReportImagesByAccidentIdAsync(long accidentId) => _client.GetMdtViewReportImagesByAccidentIdAsync(accidentId);
        public Task<RspImagesDto[]> GetRspReportImagesByActivityIdAsync(long activityId) => _client.GetRspReportImagesByActivityIdAsync(activityId);
        public Task<RspProceduresDto> GetRspReportProceduresByActivityIdAsync(long activityId) => _client.GetRspReportProceduresByActivityIdAsync(activityId);
        public Task<RspVehicleDataDto[]> GetRspReportVehicleDataByActivityIdAsync(long activityId) => _client.GetRspReportVehicleDataByActivityIdAsync(activityId);
        public Task<RspReportDto> GetRspIncidentReportAsync(long incidentId) => _client.GetRspIncidentReportAsync(incidentId);
        public Task<byte[]> GetIncidentReportPdfByIncidentIdAsync(long incidentId) => _client.GetIncidentReportPdfByIncidentIdAsync(incidentId);
        public Task<byte[]> GetIncidentReportPdfByReportIdAsync(long ReportId) => _client.GetIncidentReportPdfByReportIdAsync(ReportId);
        public Task<ReportDTO> GetAccidentReportByReportIdAsync(long ReportId) => _client.GetAccidentReportByReportIdAsync(ReportId);
        public Task<ReportDTO> GetReportDetailsByReportNumberAsync(string Reportnumber) => _client.GetReportDetailsByReportNumberAsync(Reportnumber);
        public Task<ReportDTO> GetReportPDFByReportIdAsync(long ReportId) => _client.GetReportPDFByReportIdAsync(ReportId);
        public Task<SlideShowModelDTO[]> GetReportSlideShowAsync(long ReportId) => _client.GetReportSlideShowAsync(ReportId);
        public Task<System.Tuple<int, System.DateTime>> GetLastRenewRequestReportAsync(long ReportId) => _client.GetLastRenewRequestReportAsync(ReportId);
        public Task<bool> SaveReportWithApprovalCycleAsync(ReportDTO ModifiedReport, ReportRequestDto request, FieldsToBeApprovedDTO[] Fields) => _client.SaveReportWithApprovalCycleAsync(ModifiedReport, request, Fields);
        public Task<DifferentValues[]> GetModificationListAsync(ReportDTO Modifiedreport) => _client.GetModificationListAsync(Modifiedreport);
        public Task<string> UploadIncidentReportAsync(long accidentId) => _client.UploadIncidentReportAsync(accidentId);
        public Task<bool> SaveImageCountByAccidentNumberAsync(int imageCount, string accidentNumber, int reportId) => _client.SaveImageCountByAccidentNumberAsync(imageCount, accidentNumber, reportId);
        public Task<EscortingBasicDetailsDto> GetEscortingReportBasicDetailsByActivityIdAsync(long activityId) => _client.GetEscortingReportBasicDetailsByActivityIdAsync(activityId);
        public Task<EscortingImagesDto[]> GetEscortingReportImagesByActivityIdAsync(long activityId) => _client.GetEscortingReportImagesByActivityIdAsync(activityId);
        public Task<TunnelBasicDetailsDto> GetTunnelReportBasicDetailsByActivityIdAsync(long activityId) => _client.GetTunnelReportBasicDetailsByActivityIdAsync(activityId);
        public Task<TunnelImagesDto[]> GetTunnelReportImagesByActivityIdAsync(long activityId) => _client.GetTunnelReportImagesByActivityIdAsync(activityId);

        // -------------  VEHICLE / DRIVER  -------------
        public Task<VehicleInfoResponseDto> GetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string username, string password) => _client.GetVehicleInfoAsync(requestDto, username, password);
        public Task<FTAVehicleInfoResponseDto> FTAGetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string username, string password) => _client.FTAGetVehicleInfoAsync(requestDto, username, password);
        public Task<TrafficProfileResponseDto> GetDriverInfoAsync(TrafficProfileRequestDto requestDto, string username, string password) => _client.GetDriverInfoAsync(requestDto, username, password);
        public Task<TrafficProfileResponseDto> GetFTATrafficProfileInfoAsync(TrafficProfileRequestDto requestDto, string username, string password) => _client.GetFTATrafficProfileInfoAsync(requestDto, username, password);
        public Task<VehicleAccidentHistory> GetLastAccidentHistoryAsync(string vehiclePlateNumber) => _client.GetLastAccidentHistoryAsync(vehiclePlateNumber);
        public Task<MobilePersonDto> GetPersonByIdAsync(long PersonId) => _client.GetPersonByIdAsync(PersonId);

        // -------------  MISC  -------------
        public Task<string> GetServerDateAsync() => _client.GetServerDateAsync();
        public Task<ClientCredentials> GetGoogleMapClientCredentialsAsync() => _client.GetGoogleMapClientCredentialsAsync();
        public Task<string> GetGoogleMapAPIKeyAsync() => _client.GetGoogleMapAPIKeyAsync();
        public Task SendSurveyMessageAsync(string ReportNumber, string MobileNumber, string PlateNumber) => _client.SendSurveyMessageAsync(ReportNumber, MobileNumber, PlateNumber);
        public Task<bool> SaveMobileRequestTransactionAsync(int StatusId, long RequestNumber, long PersonId, System.DateTime CreationDate) => _client.SaveMobileRequestTransactionAsync(StatusId, RequestNumber, PersonId, CreationDate);
        public Task<TranslationDto[]> GetTranslationAsync() => _client.GetTranslationAsync();
        public Task<bool> IsValidReportForDisplayAsync(string reportnumber, int numberOfValidReportDays, int numberOfValidRenewalDays) => _client.IsValidReportForDisplayAsync(reportnumber, numberOfValidReportDays, numberOfValidRenewalDays);
        public Task SendReportSMSForAllTicketsAsync(ReportDTO reportDto) => _client.SendReportSMSForAllTicketsAsync(reportDto);
        public Task SendReportSMSForOneTicketsAsync(VehicleDriverModelDTO model, string reportNumber) => _client.SendReportSMSForOneTicketsAsync(model, reportNumber);
        public Task<bool> SendReportSMSForPrivateTicketsWithLangAsync(string code, string mobilenumber, string reportNumber, string lang) => _client.SendReportSMSForPrivateTicketsWithLangAsync(code, mobilenumber, reportNumber, lang);
        public Task<bool> SendReportSMSForOneTicketsWithLangAsync(VehicleDriverModelDTO model, string reportNumber, string lang) => _client.SendReportSMSForOneTicketsWithLangAsync(model, reportNumber, lang);
        public Task SendApplicantExtendedServiceNotificationMessageAsync(long reportId) => _client.SendApplicantExtendedServiceNotificationMessageAsync(reportId);
        public Task<int> AllowedInquiryClickAsync() => _client.AllowedInquiryClickAsync();

        // -------------  REQUESTS / TRANSFER / CONFISCATION / TRAFFIC CODE  -------------
        public Task<RequestListDTO[]> GetRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal, bool myTask) => _client.GetRequestsListAsync(searchCriteria, permittedAreas, roleId, isExternal, myTask);
        public Task<RequestListDTO[]> GetClosedRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal) => _client.GetClosedRequestsListAsync(searchCriteria, permittedAreas, roleId, isExternal);
        public Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleId) => _client.GetRequestByIdAsync(requestId, roleId);
        public Task<ReportRequestDto> GetTransferedRequestByIdAsync(long requestId) => _client.GetTransferedRequestByIdAsync(requestId);
        public Task<bool> UnderProcessReportAsync(ReportTransferingDTO Report) => _client.UnderProcessReportAsync(Report);
        public Task<RequestListDTO[]> GetTransferedRequestsListAsync(ReportRequestSearchCriteriaDTO SearchCriteria, long[] PermittedAreas, System.Guid[] RoleId, long UserId) => _client.GetTransferedRequestsListAsync(SearchCriteria, PermittedAreas, RoleId, UserId);
        public Task<bool> SaveRequestAsync(ReportRequestDto request) => _client.SaveRequestAsync(request);
        public Task<bool> TransferRequestAsync(ReportRequestDto request) => _client.TransferRequestAsync(request);
        public Task<bool> CanTransferRequestAsync(long RequestId) => _client.CanTransferRequestAsync(RequestId);
        public Task<bool> TransferReportAsync(ReportTransferingDTO ConvertedReport) => _client.TransferReportAsync(ConvertedReport);
        public Task<bool> CloseReportTransferingAsync(ReportTransferingDTO ConvertedReport) => _client.CloseReportTransferingAsync(ConvertedReport);
        public Task<ReportTransferingDTO[]> GetTransferedReportListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, System.Nullable<int> TransferStatusId, int skip, int take) => _client.GetTransferedReportListAsync(search, PermittedAreas, Orgs, TransferStatusId, skip, take);
        public Task<ReportTransferingDTO[]> GetTransferedReportStatusListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, int skip, int take) => _client.GetTransferedReportStatusListAsync(search, PermittedAreas, Orgs, skip, take);
        public Task<bool> CheckReportTransferedAsync(int reportid) => _client.CheckReportTransferedAsync(reportid);
        public Task<ReportTransferingDTO[]> GetClosedTransferedReportListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, int skip, int take) => _client.GetClosedTransferedReportListAsync(search, PermittedAreas, Orgs, skip, take);
        public Task<ReportTransferingDTO> GetTransferedReportAsync(int ReportId) => _client.GetTransferedReportAsync(ReportId);
        public Task<TransferedReportLog[]> GetTransferedReportLogAsync(int ReportId) => _client.GetTransferedReportLogAsync(ReportId);
        public Task<ConfiscationDTO[]> GetConfiscationListAsync(ConfiscationListSearchCriteriaDTO search, long[] PermittedAreas) => _client.GetConfiscationListAsync(search, PermittedAreas);
        public Task<ConfiscationDTO> GetConfiscationByIdAsync(long[] PermittedAreas, long DriverDataId) => _client.GetConfiscationByIdAsync(PermittedAreas, DriverDataId);
        public Task<bool> SaveConfiscationNewStatusAndCommentAsync(ConfiscationDTO Confiscation) => _client.SaveConfiscationNewStatusAndCommentAsync(Confiscation);
        public Task<TrafficCodeDTO[]> GetTrafficCodeListAsync(TrafficCodeListSearchCriteriaDTO search, int take, int skip) => _client.GetTrafficCodeListAsync(search, take, skip);
        public Task<TrafficCodeDTO> GetTrafficCodeByIdAsync(long TrafficCodeId) => _client.GetTrafficCodeByIdAsync(TrafficCodeId);
        public Task<bool> SaveTrafficCodeAsync(TrafficCodeDTO dto) => _client.SaveTrafficCodeAsync(dto);
        public Task<bool> DeleteTrafficCodeAsync(long TrafficCodeId, long UserId) => _client.DeleteTrafficCodeAsync(TrafficCodeId, UserId);

        // -------------  TS INCIDENT LIST / MOBILE REQUEST  -------------
        public Task<TSIncidentListDTO[]> GetIncidentListAsync(IncidentSearchDto Search) => _client.GetIncidentListAsync(Search);
        public Task<MobileRequestDetailedDto> GetDetailedMobileRequestAsync(long mobileRequestId) => _client.GetDetailedMobileRequestAsync(mobileRequestId);
    }
}

