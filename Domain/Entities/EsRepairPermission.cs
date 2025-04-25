using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public partial class EsRepairPermission
{
    public long Id { get; set; }

    public long ObjectionId { get; set; }

    public int RepairPermissionTypeId { get; set; }

    public int StatusId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateCategoryId { get; set; }

    public string? PlateNumber { get; set; }

    public int? AccidentCountryId { get; set; }

    public DateTime? AccidentDate { get; set; }

    public string? ChassisNumber { get; set; }

    public int? VehicleColorId { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? VehicleType { get; set; }

    public int? VehicleModelId { get; set; }

    public string? VehicleModel { get; set; }

    public string RepairGarageName { get; set; } = null!;

    public long? CustomerDataId { get; set; }

    public long? MobileUserId { get; set; }

    public DateTime? IssuanceDate { get; set; }

    public string? DamagesDescription { get; set; }

    public int? InquiryId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public string? LastModifiedBy { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual EsRepairPermissionCountriesDim? AccidentCountry { get; set; }

    public virtual ObjectionCustomerAdditionalDatum? CustomerData { get; set; }

    public virtual ICollection<EsRepairPermissionDamagedPart> EsRepairPermissionDamagedParts { get; set; } = new List<EsRepairPermissionDamagedPart>();

    public virtual EsVehicleInquiry? Inquiry { get; set; }

    public virtual MobileUser? MobileUser { get; set; }
    [NotMapped]
    public virtual Objection Objection { get; set; } = null!;

    public virtual ItemRegistrationPlateCategoryDim? PlateCategory { get; set; }

    public virtual ItemRegistrationPlateColorDim? PlateColor { get; set; }

    public virtual PlateSourceDim? PlateSource { get; set; }

    public virtual EsRepairPermissionTypeDim RepairPermissionType { get; set; } = null!;

    public virtual EsRepairPermissionStatus Status { get; set; } = null!;

    public virtual ColorDim? VehicleColor { get; set; }

    public virtual VehicleModelDim? VehicleModelNavigation { get; set; }

    public virtual VehicleBrandDim? VehicleTypeNavigation { get; set; }
}
