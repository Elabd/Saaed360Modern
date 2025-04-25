using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VwIncidentArcfullDetail
{
    public int ReportId { get; set; }

    public long ActivityId { get; set; }

    public long? CreatedBy { get; set; }

    public int MdtaccidentBasicDetailsId { get; set; }

    public string? AccId { get; set; }

    public DateTime? IncidentDate { get; set; }

    public string? IncidentNo { get; set; }

    public string? EmariteText { get; set; }

    public string? CityText { get; set; }

    public string? AreaText { get; set; }

    public string? IncidentStatusText { get; set; }

    public string? IncidentTypeText { get; set; }

    public string? IncidentCategoryText { get; set; }

    public string? WeatherText { get; set; }

    public string? RoadSurfaceText { get; set; }

    public string? RoadSpeedText { get; set; }

    public string? AccLocDesc { get; set; }

    public int VecId { get; set; }

    public string? OwnerName { get; set; }

    public string? PlateNo { get; set; }

    public string? PlateColorText { get; set; }

    public string? PlateTypeText { get; set; }

    public string? PlateClassText { get; set; }

    public string? PlateSourceText { get; set; }

    public string? VehiclaMakeText { get; set; }

    public string? VehicleModelText { get; set; }

    public string? VehicleKindText { get; set; }

    public string? VehicleTypeText { get; set; }

    public string? VehicleProductingYear { get; set; }

    public string? VehicleCountryText { get; set; }

    public string? InsuranceCompanyText { get; set; }

    public string? InsuranceTypeText { get; set; }

    public DateTime? InsuranceExpireDate { get; set; }

    public string? VehiclesLiabilityText { get; set; }

    public string? VehicleCollisionPointText { get; set; }

    public string? VehicleStatusText { get; set; }

    public string? DriverName { get; set; }

    public string? DriverLicenceNo { get; set; }

    public string? DriverNationalityText { get; set; }

    public DateTime? DriverBirthDate { get; set; }

    public string? DriverLicenceSourceText { get; set; }

    public int? DriverLicenceTypeText { get; set; }

    public string? DriverGenderText { get; set; }

    public DateTime? DriverLicenceExpDate { get; set; }

    public string? DriverEducationLevelText { get; set; }

    public int? DriverOccupationText { get; set; }

    public string? DriverStatusText { get; set; }

    public string? DriverRunningStatusText { get; set; }

    public string? DriverDrinkingStatusText { get; set; }

    public string? HoldDocumentsText { get; set; }

    public string? HoldDocumentPlaceText { get; set; }

    public string? Damges { get; set; }

    public string ItemDescA { get; set; } = null!;

    public string IsMain { get; set; } = null!;

    public string? Other { get; set; }

    public int? ObjId { get; set; }

    public int? ObjTypeTxt { get; set; }

    public int? ObjInjTxt { get; set; }

    public int? ObjInjLvlTxt { get; set; }

    public int? ObjOwnerTxt { get; set; }

    public int? ObjOther { get; set; }
}
