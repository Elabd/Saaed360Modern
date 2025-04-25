using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VehicleDatum
{
    public int VehicleDataId { get; set; }

    public string? Comments { get; set; }

    public bool? IsVehicleGoodAndNotRemoved { get; set; }

    public string? PlateNumber { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public int? VehicleBrandId { get; set; }

    public int? VehicleModelId { get; set; }

    public int? VehicleTypeId { get; set; }

    public int? VehicleCategoryId { get; set; }

    public int? ManufactureYearId { get; set; }

    public int? CountryOfOriginId { get; set; }

    public string? ChasisNumber { get; set; }

    public int? VehicleColorId { get; set; }

    public string? EngineNumber { get; set; }

    public string? WeightEmpty { get; set; }

    public string? WeightNonEmpty { get; set; }

    public int? InsuranceCompanyId { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? InsurancePolicyNumber { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? VehicleDescription { get; set; }

    public int? GlassColorId { get; set; }

    public int? CollisionId { get; set; }

    public int? ChemicalId { get; set; }

    public int? VehicleStatusId { get; set; }

    public int? ReasonCategoryId { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool? IsVehicleWithoutPlateNumber { get; set; }

    public string? ReasonCategoryDescription { get; set; }

    public int? SelectedCausedVehicleTypeId { get; set; }

    public string? VehicleStatusComment { get; set; }

    public string? ReportCode { get; set; }

    public long? DeliveryCompanyId { get; set; }

    public string? DeliveryCompanyOthers { get; set; }

    public bool? IsAirBagOpened { get; set; }

    public string? CombinedPlateNumber { get; set; }

    public int? VehicleEnergySourceId { get; set; }

    public virtual ICollection<ArmyNotificationLog> ArmyNotificationLogs { get; set; } = new List<ArmyNotificationLog>();

    public virtual ChemicalDim? Chemical { get; set; }

    public virtual CollisionDim? Collision { get; set; }

    public virtual GeoCountryDim? CountryOfOrigin { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<DamagedVehiclePart> DamagedVehicleParts { get; set; } = new List<DamagedVehiclePart>();

    public virtual DeliveryCompanyDim? DeliveryCompany { get; set; }

    public virtual ICollection<DriverDatum> DriverData { get; set; } = new List<DriverDatum>();

    public virtual GlassColorDim? GlassColor { get; set; }

    public virtual InsuranceCompanyDim? InsuranceCompany { get; set; }

    public virtual InsuranceTypeDim? InsuranceType { get; set; }

    public virtual ItemRegistrationPlateCategoryDim? ItemRegistrationPlateCategory { get; set; }

    public virtual ItemRegistrationPlateColorDim? ItemRegistrationPlateColor { get; set; }

    public virtual ItemRegistrationPlateKindDim? ItemRegistrationPlateKind { get; set; }

    public virtual YearDim? ManufactureYear { get; set; }

    public virtual ICollection<OwnerDatum> OwnerData { get; set; } = new List<OwnerDatum>();

    public virtual PlateSourceDim? PlateSource { get; set; }

    public virtual ICollection<PurchaseRequest> PurchaseRequests { get; set; } = new List<PurchaseRequest>();

    public virtual ReportReasonDim? ReasonCategory { get; set; }

    public virtual ICollection<RepairRequest> RepairRequests { get; set; } = new List<RepairRequest>();

    public virtual ICollection<ReportImage> ReportImages { get; set; } = new List<ReportImage>();

    public virtual ICollection<ReportVehicleDatum> ReportVehicleData { get; set; } = new List<ReportVehicleDatum>();

    public virtual ICollection<SaaedIdamagePartsIntegrationLog> SaaedIdamagePartsIntegrationLogs { get; set; } = new List<SaaedIdamagePartsIntegrationLog>();

    public virtual ICollection<SaaedIplateNumbersIntegrationLog> SaaedIplateNumbersIntegrationLogs { get; set; } = new List<SaaedIplateNumbersIntegrationLog>();

    public virtual ICollection<SaaedIprocessedImage> SaaedIprocessedImages { get; set; } = new List<SaaedIprocessedImage>();

    public virtual VehicleTypeDim? SelectedCausedVehicleType { get; set; }

    public virtual ICollection<TrafficViolation> TrafficViolations { get; set; } = new List<TrafficViolation>();

    public virtual VehicleBrandDim? VehicleBrand { get; set; }

    public virtual VehicleCategoryDim? VehicleCategory { get; set; }

    public virtual ColorDim? VehicleColor { get; set; }

    public virtual ICollection<VehicleDamagePart> VehicleDamageParts { get; set; } = new List<VehicleDamagePart>();

    public virtual ICollection<VehicleDamagedPart> VehicleDamagedParts { get; set; } = new List<VehicleDamagedPart>();

    public virtual VehicleDataTypeDim? VehicleDataType { get; set; }

    public virtual VehicleModelDim? VehicleModel { get; set; }

    public virtual VehicleStatusDim? VehicleStatus { get; set; }

    public virtual VehicleTypeDim? VehicleType { get; set; }
}
