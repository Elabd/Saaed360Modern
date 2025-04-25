using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewRepairPermission
{
    public long RepairPermissionId { get; set; }

    public long ObjectionId { get; set; }

    public long? EmirateId { get; set; }

    public DateTime ObjectionDate { get; set; }

    public string? ApplicantName { get; set; }

    public string? EmiratesId { get; set; }

    public string? TrafficCode { get; set; }

    public string MobileNumber { get; set; } = null!;

    public int? PereferredCommunicationMethod { get; set; }

    public int RepairPermissionTypeId { get; set; }

    public string RepairPermissionType { get; set; } = null!;

    public int StatusId { get; set; }

    public string Status { get; set; } = null!;

    public string? PlateNumber { get; set; }

    public int? PlateSourceId { get; set; }

    public string? PlateSourceArabic { get; set; }

    public int? PlateColorId { get; set; }

    public string? PlateColorArabic { get; set; }

    public int? PlateCategoryId { get; set; }

    public string? PlateCategoryArabic { get; set; }

    public int? AccidentCountryId { get; set; }

    public string? AccidentCountryArabic { get; set; }

    public DateTime? AccidentDate { get; set; }

    public string RepairGarageName { get; set; } = null!;

    public string? DamagesDescription { get; set; }

    public string? ChassisNumber { get; set; }

    public int? VehicleColorId { get; set; }

    public string? VehicleColorArabic { get; set; }

    public string? VehicleType { get; set; }

    public string? VehicleModel { get; set; }

    public int? MobileUserId { get; set; }

    public DateTime? IssuanceDate { get; set; }
}
