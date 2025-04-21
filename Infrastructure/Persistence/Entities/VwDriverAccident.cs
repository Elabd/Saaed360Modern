using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VwDriverAccident
{
    public string? DriverName { get; set; }

    public string? MobileNumber { get; set; }

    public string? MobileNumberCoreDigits { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? ReportNumber { get; set; }

    public string? ReportStatus { get; set; }

    public string? ReportType { get; set; }

    public string? VehicleDataType { get; set; }

    public string? PlateNumber { get; set; }

    public string? PlateSource { get; set; }

    public string? DamagedPartsDetails { get; set; }
}
