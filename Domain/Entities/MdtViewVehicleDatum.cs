using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MdtViewVehicleDatum
{
    public int ReportId { get; set; }

    public int VehicleDataId { get; set; }

    public bool? IsVehicleWithoutPlateNumber { get; set; }

    public string? PlateNumber { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleCategoryId { get; set; }

    public string? ChasisNumber { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public int? ReasonCategoryId { get; set; }

    public int? VehicleStatusId { get; set; }

    public string? InsurancePolicyNumber { get; set; }

    public int? CountryOfOriginId { get; set; }

    public DateTime? VehicleDataExpiryDate { get; set; }

    public string? EngineNumber { get; set; }

    public int? ChemicalId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ManufactureYearId { get; set; }

    public int? VehicleColorId { get; set; }

    public string? WeightNonEmpty { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? WeightEmpty { get; set; }

    public int? GlassColorId { get; set; }

    public string? VehicleDataComments { get; set; }

    public int? CollisionId { get; set; }

    public string? VehicleDescription { get; set; }

    public bool? IsVehicleGoodAndNotRemoved { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public string? VehicleDataCausingType { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public string? OwnerDataTrafficCode { get; set; }

    public int? OwnerDataId { get; set; }

    public string? OwnerDataAddress { get; set; }

    public string? OwnerDataName { get; set; }

    public int? OwnerDataNationalityId { get; set; }

    public bool? IsDriverHaveLicense { get; set; }

    public int? DriverDataId { get; set; }

    public string? DriverDataName { get; set; }

    public int? DriverDataNationalityId { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public DateTime? DriverDataExpiryDate { get; set; }

    public DateTime? DriverDataBirthDate { get; set; }

    public int? CareerId { get; set; }

    public int? GenderId { get; set; }

    public int? EscapedStatusId { get; set; }

    public int? DriverDrinkingStatusId { get; set; }

    public int? ConfiscationDocumentTypeId { get; set; }

    public int? ConfiscationLocationId { get; set; }

    public string? DriverDataTrafficCode { get; set; }

    public string? DriverDataLicenseNumber { get; set; }

    public DateTime? DriverDataIssueDate { get; set; }

    public int? DriverDataLicenseCategoryId { get; set; }

    public string? DriverDataMobileNumber { get; set; }

    public int? EducationStatusId { get; set; }

    public int? DriverStatusId { get; set; }

    public string? DriverDataAddress { get; set; }

    public int? DamagedVehiclePartsId { get; set; }

    public string? DamagedPartsDetails { get; set; }
}
