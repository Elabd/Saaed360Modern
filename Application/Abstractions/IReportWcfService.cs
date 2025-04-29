// Auto‑generated convenience wrapper for WCF proxy – singleton‑friendly
// ---------------------------------------------------------------
// Usage:
//     builder.Services.AddSingleton<IReportWcfService, ReportWcfService>();
// ---------------------------------------------------------------

using System;
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
        Task<LookupDto> GetServiceCenterByEmiratesIdAsync(long emiratesId);
        Task<LookupDto[]> GetCityBySelectedEmirateIdAsync(long emirateId);
        Task<LookupDto[]> GetAreaByCityIdAsync(long CityId);
        Task<LookupDto[]> GetAllAreasAsync();
        Task<LookupDto[]> GetSectorByAreaIdAsync(long AreaId);
        Task<LookupDto[]> GetAllSectorsAsync();
        Task<LookupDto[]> GetAllStreetsAsync();
        Task<LookupDto[]> GetAllCrossStreetsAsync();
        Task<LookupDto[]> GetStreetBySelectedAreaIdAsync(long areaId);
        Task<LookupDto[]> GetCrossingStreetBySelectedAreaIdAsync(long areaId);
        Task<LookupDto[]> GetReportTypeValuesAsync(System.Nullable<int> statusid);
        Task<LookupDto[]> GetListOfWeatherAsync();
        Task<LookupDto[]> GetListOfRoadSurfaceAsync();
        Task<LookupDto[]> GetListOfRoadSpeedAsync();
        Task<LookupDto[]> GetListOfIntersectionsAsync();
        Task<LookupDto[]> GetListOfAccidentTypesAsync();
        Task<LookupDto[]> GetListOfNationalityAsync();
        Task<LookupDto[]> GetListOfInjuryLevelAsync();
        Task<LookupDto[]> GetListOfInjuryTypeAsync();
        Task<LookupDto[]> GetListOfOrganisationAsync();
        Task<LookupDto[]> GetPublicDamagePartAsync();
        Task<LookupDto[]> GetPrivateDamagePartAsync();
        Task<LookupDto[]> GetListOfObjectsBySelectedOrganisationAsync(long organisationId);
        Task<LookupDto[]> GetPlateSourceByPlateTypeId1Async(System.Nullable<long> plateColor, System.Nullable<long> PlateCategory, System.Nullable<long> plateTypeId);
        Task<LookupDto[]> GetPlateSourceByPlateTypeIdAsync(System.Nullable<long> plateTypeId);
        Task<LookupDto[]> GetPlateSourceByListofPlateTypeIdsAsync(long[] plateTypeIds);
        Task<LookupDto[]> GetPlateClassByPlateColorIdAsync(System.Nullable<long> plateColorId);
        Task<LookupDto[]> GetPlateClassByListofPlateColorIdAsync(long[] plateColorIds);
        Task<LookupDto[]> GetPlateColorAsync();
        Task<LookupDto[]> GetPlateTypeByPlateClassId1Async(System.Nullable<long> plateClassId, System.Nullable<long> plateColorId);
        Task<LookupDto[]> GetPlateTypeByPlateClassIdAsync(System.Nullable<long> plateClassId);
        Task<LookupDto[]> GetPlateTypeByListofPlateClassIdsAsync(long[] plateClassIds);
        Task<LookupDto[]> GetListOfVehicleBrandsAsync();
        Task<LookupDto[]> GetListOfVehicleModelBySelectedVehicleBrandAsync(int vehicleBrandId);
        Task<LookupDto[]> GetListOfVehicleTypeBySelectedVehicleModelAsync(System.Nullable<int> vehicleModelId);
        Task<LookupDto[]> GetListOfVehicleCategoryBySelectedVehicleTypeAsync(int vehicleTypeId);
        Task<LookupDto[]> GetListOfVehicleModelBySelectedVehicleBrandsAsync(int[] vehicleBrandId);
        Task<LookupDto[]> GetListOfVehicleTypesAsync(System.Nullable<int>[] vehicleModelId);
        Task<LookupDto[]> GetListOfVehicleCategoryBySelectedVehicleTypesAsync(System.Nullable<int>[] vehicleTypeId);
        Task<LookupDto[]> GetListOfManufatureYearsAsync();
        Task<LookupDto> GetManufactureYearByNameAsync(string year);
        Task<LookupDto[]> GetListOfCountryOfOriginsAsync();
        Task<LookupDto> GetOriginCountryByCodeAsync(string Code);
        Task<LookupDto[]> GetAllReasonOfAccidentsAsync();
        Task<LookupDto[]> GetListOfVehileColorsAsync();
        Task<LookupDto[]> GetListOfInsuranceCompanyAsync();
        Task<LookupDto[]> GetListOfInsuranceTypesAsync();
        Task<LookupDto[]> GetListOfGlassColorsAsync();
        Task<LookupDto[]> GetListOfCollisionPointsAsync();
        Task<LookupDto[]> GetListOfChemicalsAsync();
        Task<LookupDto[]> GetListOfVehicleStateAsync();
        Task<LookupDto[]> GetListOfReasonOfAccidentsAsync();
        Task<LookupDto[]> GetListOfLicenseSourceAsync();
        Task<LookupDto[]> GetListOfLicenseCategoryAsync();
        Task<LookupDto[]> GetListOfGenderAsync();
        Task<LookupDto[]> GetListOfCareerAsync();
        Task<LookupDto[]> GetListOfEducationLevelAsync();
        Task<LookupDto[]> GetListOfEscapedStatusAsync();
        Task<LookupDto[]> GetListOfDriverStatusAsync();
        Task<LookupDto[]> GetListOfDriverDrinkingStatusAsync();
        Task<LookupDto[]> GetListOfConfiscationsDocumentTypesAsync();
        Task<LookupDto[]> GetAllConfiscationStatusAsync();
        Task<LookupDto[]> GetListOfConfiscationsLocationsAsync();
        Task<LookupDto[]> GetReportEmirateAsync();
        Task<LookupDto[]> GetHowAccidentHappenedAsync();
        Task<LookupDto[]> GetSourceOfModificationAsync();
        Task<LookupDto[]> GetReportModificationResponsibilityDIMAsync();
        Task<TransferStatusDTO[]> GetTransferedStatusListAsync();

        // --------------------  INCIDENT / REPORT  --------------------
        Task<TicketDTO[]> GetPrintingTicketDataAsync(long incidentId);
        Task<RspBasicDetailsDto> GetRspReportBasicDetailsByActivityIdAsync(long activityId);
        Task<ReportDTO> GetReportByReportIdAsync(long reportId);
        Task<ReportDTO[]> GetIncidentReportAsync(long incidentId);
        Task<int> SaveIncidentReportAsync(ReportDTO reportObject);
        Task<SaveReportResponse> SaveOfflineIncidentReportAsync(ReportDTO reportObject, ReportAmbulanceDTO reportAmbulance, string reportDtoRaw);
        Task<CanSaveReportResponse> CanSaveReportAsync(string incidentNo, string reportNumber, long patrolId);
        Task<int> SaveRspIncidentReportAsync(RspReportDto reportObject);
        Task<VehicleDriverModelDTO[]> GetMdtViewVehicleDataByAccidentIdAsync(long accidentId);
        Task<SlideShowModelDTO[]> GetMdtViewReportImagesByAccidentIdAsync(long accidentId);
        Task<RspImagesDto[]> GetRspReportImagesByActivityIdAsync(long activityId);
        Task<RspProceduresDto> GetRspReportProceduresByActivityIdAsync(long activityId);
        Task<RspVehicleDataDto[]> GetRspReportVehicleDataByActivityIdAsync(long activityId);
        Task<RspReportDto> GetRspIncidentReportAsync(long incidentId);
        Task<byte[]> GetIncidentReportPdfByIncidentIdAsync(long incidentId);
        Task<byte[]> GetIncidentReportPdfByReportIdAsync(long ReportId);
        Task<ReportDTO> GetAccidentReportByReportIdAsync(long ReportId);
        Task<ReportDTO> GetReportDetailsByReportNumberAsync(string Reportnumber);
        Task<ReportDTO> GetReportPDFByReportIdAsync(long ReportId);
        Task<SlideShowModelDTO[]> GetReportSlideShowAsync(long ReportId);
        Task<System.Tuple<int, System.DateTime>> GetLastRenewRequestReportAsync(long ReportId);
        Task<bool> SaveReportWithApprovalCycleAsync(ReportDTO ModifiedReport, ReportRequestDto request, FieldsToBeApprovedDTO[] Fields);
        Task<DifferentValues[]> GetModificationListAsync(ReportDTO Modifiedreport);
        Task<string> UploadIncidentReportAsync(long accidentId);
        Task<bool> SaveImageCountByAccidentNumberAsync(int imageCount, string accidentNumber, int reportId);
        Task<EscortingBasicDetailsDto> GetEscortingReportBasicDetailsByActivityIdAsync(long activityId);
        Task<EscortingImagesDto[]> GetEscortingReportImagesByActivityIdAsync(long activityId);
        Task<TunnelBasicDetailsDto> GetTunnelReportBasicDetailsByActivityIdAsync(long activityId);
        Task<TunnelImagesDto[]> GetTunnelReportImagesByActivityIdAsync(long activityId);

        // --------------------  VEHICLE / DRIVER  --------------------
        Task<VehicleInfoResponseDto> GetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string userName, string password);
        Task<FTAVehicleInfoResponseDto> FTAGetVehicleInfoAsync(VehicleInfoRequestDto requestDto, string userName, string password);
        Task<TrafficProfileResponseDto> GetDriverInfoAsync(TrafficProfileRequestDto requestDto, string userName, string password);
        Task<TrafficProfileResponseDto> GetFTATrafficProfileInfoAsync(TrafficProfileRequestDto requestDto, string userName, string password);
        Task<VehicleAccidentHistory> GetLastAccidentHistoryAsync(string vehiclePlateNumber);
        Task<MobilePersonDto> GetPersonByIdAsync(long PersonId);

        // --------------------  MISC  --------------------
        Task<string> GetServerDateAsync();
        Task<ClientCredentials> GetGoogleMapClientCredentialsAsync();
        Task<string> GetGoogleMapAPIKeyAsync();
        Task SendSurveyMessageAsync(string ReportNumber, string MobileNumber, string PlateNumber);
        Task<bool> SaveMobileRequestTransactionAsync(int StatusId, long RequestNumber, long PersonId, System.DateTime CreationDate);
        Task<TranslationDto[]> GetTranslationAsync();
        Task<bool> IsValidReportForDisplayAsync(string reportnumber, int numberOfValidReportDays, int numberOfValidRenewalDays);
        Task SendReportSMSForAllTicketsAsync(ReportDTO reportDto);
        Task SendReportSMSForOneTicketsAsync(VehicleDriverModelDTO model, string reportNumber);
        Task<bool> SendReportSMSForPrivateTicketsWithLangAsync(string code, string mobilenumber, string reportNumber, string lang);
        Task<bool> SendReportSMSForOneTicketsWithLangAsync(VehicleDriverModelDTO model, string reportNumber, string lang);
        Task SendApplicantExtendedServiceNotificationMessageAsync(long reportId);
        Task<int> AllowedInquiryClickAsync();

        // --------------------  REQUESTS / TRANSFER / CONFISCATION / TRAFFIC CODE  --------------------
        Task<RequestListDTO[]> GetRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal, bool myTask);
        Task<RequestListDTO[]> GetClosedRequestsListAsync(ReportRequestSearchCriteriaDTO searchCriteria, long[] permittedAreas, Guid[] roleId, bool isExternal);
        Task<ReportRequestDto> GetRequestByIdAsync(long requestId, Guid[] roleId);
        Task<ReportRequestDto> GetTransferedRequestByIdAsync(long requestId);
        Task<bool> UnderProcessReportAsync(ReportTransferingDTO Report);
        Task<RequestListDTO[]> GetTransferedRequestsListAsync(ReportRequestSearchCriteriaDTO SearchCriteria, long[] PermittedAreas, System.Guid[] RoleId, long UserId);
        Task<bool> SaveRequestAsync(ReportRequestDto request);
        Task<bool> TransferRequestAsync(ReportRequestDto request);
        Task<bool> CanTransferRequestAsync(long RequestId);
        Task<bool> TransferReportAsync(ReportTransferingDTO ConvertedReport);
        Task<bool> CloseReportTransferingAsync(ReportTransferingDTO ConvertedReport);
        Task<ReportTransferingDTO[]> GetTransferedReportListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, System.Nullable<int> TransferStatusId, int skip, int take);
        Task<ReportTransferingDTO[]> GetTransferedReportStatusListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, int skip, int take);
        Task<bool> CheckReportTransferedAsync(int reportid);
        Task<ReportTransferingDTO[]> GetClosedTransferedReportListAsync(ReportTransferingSearchCriteriaDTO search, long[] PermittedAreas, long[] Orgs, int skip, int take);
        Task<ReportTransferingDTO> GetTransferedReportAsync(int ReportId);
        Task<TransferedReportLog[]> GetTransferedReportLogAsync(int ReportId);
        Task<ConfiscationDTO[]> GetConfiscationListAsync(ConfiscationListSearchCriteriaDTO search, long[] PermittedAreas);
        Task<ConfiscationDTO> GetConfiscationByIdAsync(long[] PermittedAreas, long DriverDataId);
        Task<bool> SaveConfiscationNewStatusAndCommentAsync(ConfiscationDTO Confiscation);
        Task<TrafficCodeDTO[]> GetTrafficCodeListAsync(TrafficCodeListSearchCriteriaDTO search, int take, int skip);
        Task<TrafficCodeDTO> GetTrafficCodeByIdAsync(long TrafficCodeId);
        Task<bool> SaveTrafficCodeAsync(TrafficCodeDTO dto);
        Task<bool> DeleteTrafficCodeAsync(long TrafficCodeId, long UserId);

        // --------------------  TS INCIDENT LIST / MOBILE REQUEST  --------------------
        Task<TSIncidentListDTO[]> GetIncidentListAsync(IncidentSearchDto Search);
        Task<MobileRequestDetailedDto> GetDetailedMobileRequestAsync(long mobileRequestId);
    }
}

