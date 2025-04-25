using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class MobileRequestVehicle
{
    public long Id { get; set; }

    public int? PlateSourceId { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateColorId { get; set; }

    public string? PlateNumber { get; set; }

    public string? DriverLicenseNumber { get; set; }

    public int? DriverLicenseSourceId { get; set; }

    public long? RequestNumber { get; set; }

    public string? Comment { get; set; }

    public int? RoleCodeId { get; set; }

    public int? PlateClassId { get; set; }

    public bool? IsDeleted { get; set; }

    public string? DriverMobileNumber { get; set; }

    public int? VehicleSerial { get; set; }

    public string? DeviceCode { get; set; }

    public virtual ICollection<MobileRequestImage> MobileRequestImages { get; set; } = new List<MobileRequestImage>();

    public virtual MobileRequest? RequestNumberNavigation { get; set; }
}
