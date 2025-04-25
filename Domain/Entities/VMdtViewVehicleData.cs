using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VMdtViewVehicleData
{
    public int VehicleDataId { get; set; }

    public int ReportId { get; set; }

    public bool? IsVehicleWithoutPlateNumber { get; set; }

    public string? PlateNumber { get; set; }

    public string? CombinedPlateNumber { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public string? ItemRegistrationPlateColor { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleCategoryId { get; set; }

    public string? ChasisNumber { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleModel { get; set; }

    public int? ReasonCategoryId { get; set; }

    public string? ReasonCategory { get; set; }

    public string? ReasonCategoryCode { get; set; }

    public int? VehicleStatusId { get; set; }

    public string? InsurancePolicyNumber { get; set; }

    public int? CountryOfOriginId { get; set; }

    public DateTime? VehicleDataExpiryDate { get; set; }

    public string? EngineNumber { get; set; }

    public int? ChemicalId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ManufactureYearId { get; set; }

    public string? ManufactureYear { get; set; }

    public int? VehicleColorId { get; set; }

    public string? VehicleColor { get; set; }

    public string? WeightNonEmpty { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? WeightEmpty { get; set; }

    public int? GlassColorId { get; set; }

    public string? Color { get; set; }

    public string? VehicleDataComments { get; set; }

    public int? CollisionId { get; set; }

    public string? Collision { get; set; }

    public string? VehicleDescription { get; set; }

    public bool? IsVehicleGoodAndNotRemoved { get; set; }

    public int? SelectedCausedVehicleTypeId { get; set; }

    public string? SelectedCausedVehicleType { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public string? VehicleDataCausingType { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public string? OwnerDataTrafficCode { get; set; }

    public int? OwnerDataId { get; set; }

    public string? OwnerDataAddress { get; set; }

    public string? ReportCode { get; set; }

    public string? OwnerDataName { get; set; }

    public string? OwnerNationality { get; set; }

    public int? OwnerDataNationalityId { get; set; }

    public bool? IsDriverHaveLicense { get; set; }

    public int? DriverDataId { get; set; }

    public string? DriverDataName { get; set; }

    public int? DriverDataNationalityId { get; set; }

    public string? DriverNationality { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public DateTime? DriverDataExpiryDate { get; set; }

    public DateTime? DriverDataBirthDate { get; set; }

    public int? CareerId { get; set; }

    public int? GenderId { get; set; }

    public int? EscapedStatusId { get; set; }

    public int? DriverDrinkingStatusId { get; set; }

    public int? ConfiscationDocumentTypeId { get; set; }

    public string? ConfiscationDocumentType { get; set; }

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

    public string? DamagePartsDescription { get; set; }

    public string? DamagedPartsDetails { get; set; }

    public string? LicenseCategory { get; set; }

    public string? Gender { get; set; }

    public string? Career { get; set; }

    public string? EducationStatus { get; set; }

    public string? EscapedStatus { get; set; }

    public string? DriverStatus { get; set; }

    public string? DriverDrinkingStatus { get; set; }

    public string? ConfiscationLocation { get; set; }

    public string? PlateSource { get; set; }

    public bool? PlateSourceInEmirates { get; set; }

    public string? VehicleBrand { get; set; }

    public string? ItemRegistrationPlateKind { get; set; }

    public string? ItemRegistrationPlateCategory { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleCategory { get; set; }

    public string? GeoCountry { get; set; }

    public string? InsuranceCompany { get; set; }

    public string? InsuranceType { get; set; }

    public string? Chemical { get; set; }

    public string? VehicleStatus { get; set; }

    public string? VehicleStatusCode { get; set; }

    public string? VehicleDataType { get; set; }

    public string? LicensePlateListSource { get; set; }

    public bool? LicensePlateSourceInEmirates { get; set; }

    public string? ReasonCategoryDescription { get; set; }

    public string? VehicleStatusComment { get; set; }

    public string? DeliveryCompany { get; set; }

    public string? DeliveryCompanyCode { get; set; }

    public string? DeliveryCompanyDescription { get; set; }

    public string? DeliveryCompanyOthers { get; set; }

    public string? AccidentDamageSize { get; set; }

    public long? AccidentDamageSizeId { get; set; }

    public long? DeliveryCompanyId { get; set; }

    public int? VehicleEnergySourceId { get; set; }

    public string? VehicleEnergySourceArabic { get; set; }

    public string? VehicleEnergySourceEnglish { get; set; }

    public bool? IsAirBagOpened { get; set; }
}
