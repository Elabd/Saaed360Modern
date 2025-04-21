using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MdtGetRspVehicleDatum
{
    public long RspVehicleDataId { get; set; }

    public int ReportId { get; set; }

    public bool? IsNoVehiclePresent { get; set; }

    public int? VehicleTypeId { get; set; }

    public string? PlateNumber { get; set; }

    public int? PlateColorId { get; set; }

    public int? PlateTypeId { get; set; }

    public int? PlateCategoryId { get; set; }

    public int? PlateSourceId { get; set; }

    public string? TrafficCode { get; set; }

    public int? ManufactureYearId { get; set; }

    public bool? IsInsured { get; set; }

    public long? VehicleDamagedTypeId { get; set; }

    public long RspDriverDataId { get; set; }

    public bool? IsDriverHasNoLicense { get; set; }

    public string? DriverTrafficCode { get; set; }

    public string? LicenseNumber { get; set; }

    public int? LicenseSourceId { get; set; }

    public string? DriverName { get; set; }

    public int? NationalityId { get; set; }

    public int? GenderId { get; set; }

    public string? PhoneNumber { get; set; }

    public int? LicenseCategoryId { get; set; }
}
