using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class GetMdtaccidentReportRequiredField
{
    public long ActivityId { get; set; }

    public int ReportId { get; set; }

    public string? ReportStatusCode { get; set; }

    public long StreetId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public int? ReportTypeId { get; set; }

    public long CrossingStreetId { get; set; }

    public int? WeatherId { get; set; }

    public int? RoadSpeedId { get; set; }

    public int? IntersectionId { get; set; }

    public int? RoadSurfaceId { get; set; }

    public long OrganizationId { get; set; }

    public int PropertyTypeId { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public int? ChemicalId { get; set; }

    public int? GlassColorId { get; set; }

    public string? DriverDataTrafficCode { get; set; }

    public string? DriverDataLicenseNumber { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public DateTime? DriverDataLicenseExpiryDate { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public string? InsurancePolicyNumber { get; set; }

    public DateTime? VehicleDataInsuranceExpiryDate { get; set; }

    public string? PlateNumber { get; set; }

    public int IsMainVehicle { get; set; }

    public int? ReasonCategoryId { get; set; }

    public string? DamagedPartsId { get; set; }

    public string? OwnerDataName { get; set; }

    public string? DriverDataName { get; set; }

    public int? DriverStatusId { get; set; }

    public int? VehicleStatusId { get; set; }

    public int? CollisionId { get; set; }

    public string? OwnerDataTrafficCode { get; set; }

    public int? ManufactureYearId { get; set; }

    public int? VehicleColorId { get; set; }

    public int? CountryOfOriginId { get; set; }

    public string? ChasisNumber { get; set; }

    public int? VehicleDataId { get; set; }

    public long? PlateMatrixId { get; set; }

    public long? VehicleMatrixId { get; set; }
}
