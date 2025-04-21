using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VUploadAccidentInvolvedDatum
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public int? IntYear { get; set; }

    public long? EmiratesId { get; set; }

    public long? StreetId { get; set; }

    public int? ReportTypeId { get; set; }

    public int? IntRoleCode { get; set; }

    public string StrIsChemicalDanger { get; set; } = null!;

    public string StrIsWinTinted { get; set; } = null!;

    public string? LngTcfNumber { get; set; }

    public string? LngDrivingLicenseNumber { get; set; }

    public int? IntDrivingLicenseSourceCode { get; set; }

    public DateTime? DtDrivingLicenseExpiryDate { get; set; }

    public int? IntInsuranceCompanyCode { get; set; }

    public string? StrInsurancePolicy { get; set; }

    public DateTime? DtInsuranceExpiry { get; set; }

    public string? StrPno { get; set; }

    public string? StrChaseNumber { get; set; }

    public int? IntVehNatCode { get; set; }

    public int? IntVehMakeCode { get; set; }

    public int? IntVehModelCode { get; set; }

    public int? IntVehKindCode { get; set; }

    public int? IntVehTypeCode { get; set; }

    public int? IntVehYear { get; set; }

    public string IntVehYearFull { get; set; } = null!;

    public int? IntVehColorCode { get; set; }

    public int? IntPcolorCode { get; set; }

    public int? IntPtypeCode { get; set; }

    public int? IntPkindCode { get; set; }

    public int? IntPsourceCode { get; set; }

    public string? LngOwnTcfNumber { get; set; }

    public int? IntPointOfCrachCode { get; set; }

    public int? IntVehStatusCode { get; set; }

    public string? StrVehStatusDesc { get; set; }

    public string? StrDrvAwarenessDesc { get; set; }

    public string? StrOwnerName { get; set; }

    public string? StrDriverName { get; set; }

    public int? DriverDrinkingStatusId { get; set; }

    public int? ConfiscationDocumentTypeId { get; set; }

    public int? ConfiscationLocationId { get; set; }

    public int? DriverStatusId { get; set; }

    public int? EscapedStatusId { get; set; }

    public int? EducationStatusId { get; set; }

    public string? MobileNumber { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? GenderId { get; set; }

    public int? LicenseCategoryId { get; set; }

    public int? ConfiscationStatusId { get; set; }

    public int? VehicleDataId { get; set; }

    public string? CountryCode { get; set; }

    public string? EngineNumber { get; set; }

    public string? WeightEmpty { get; set; }

    public string? WeightNonEmpty { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? VehicleStatusComment { get; set; }

    public int? NationalityId { get; set; }

    public DateTime? IssueDate { get; set; }

    public long? CreatedBy { get; set; }
}
