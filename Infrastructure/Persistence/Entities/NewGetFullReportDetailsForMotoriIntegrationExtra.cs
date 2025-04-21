using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class NewGetFullReportDetailsForMotoriIntegrationExtra
{
    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? ReportNumber { get; set; }

    public int ReportId { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? AccidentReasonComment { get; set; }

    public int? ReasonCategoryId { get; set; }

    public int? ReportTypeId { get; set; }

    public int? AccidentTypeId { get; set; }

    public long? EmiratesId { get; set; }

    public long? CityId { get; set; }

    public long? RegionId { get; set; }

    public long? StreetId { get; set; }

    public string? NorthernCoOrdinate { get; set; }

    public string? EasternCoOrdinate { get; set; }

    public int? IntersectionId { get; set; }

    public int? RoadSpeedId { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public string? PlateNumber { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public int? VehicleStatusId { get; set; }

    public int VehicleDataId { get; set; }

    public int? ScenarioId { get; set; }

    public string? ChasisNumber { get; set; }

    public string? TrafficCode { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? Name { get; set; }

    public int? NationalityId { get; set; }

    public string? DriverTcn { get; set; }

    public string? DriverName { get; set; }

    public int? DriverNationality { get; set; }

    public string? LicenseNumber { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public int? LicenseCategoryId { get; set; }

    public int? GenderId { get; set; }

    public DateTime? BirthDate { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? InsurancePolicyNumber { get; set; }

    public string? StreetName { get; set; }

    public string? AccidentTypeName { get; set; }

    public string? ReasonCategoryName { get; set; }

    public string? EmirateName { get; set; }

    public string? CityName { get; set; }

    public string? InsuranceCompanyName { get; set; }

    public string? InsuranceTypeName { get; set; }

    public int? CarModelYearId { get; set; }

    public string? CarModelYear { get; set; }

    public int? VehicleMakeId { get; set; }

    public string? VehicleMake { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleModel { get; set; }

    public string? IntersectionName { get; set; }

    public string? DamagedPartsDetails { get; set; }

    public string? DriverGender { get; set; }

    public string? DriverNationalityName { get; set; }

    public long? CollisionTypeId { get; set; }

    public long? AccidentLocationDescriptionId { get; set; }

    public bool? IsMonitoringWithCamera { get; set; }

    public long? AccidentDamageSizeId { get; set; }

    public long? DeliveryCompanyId { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? VehicleCategory { get; set; }

    public int? VehicleCategoryId { get; set; }

    public string? VehicleType { get; set; }
}
