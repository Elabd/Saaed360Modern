using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportVehicleDataView
{
    public int ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public string? PlateNumber { get; set; }

    public int? ItemRegistrationPlateColorId { get; set; }

    public int? ItemRegistrationPlateKindId { get; set; }

    public int? PlateSourceId { get; set; }

    public int? ItemRegistrationPlateCategoryId { get; set; }

    public string? OwnerTrafficCode { get; set; }

    public string? OwnerName { get; set; }

    public string? DriverName { get; set; }

    public int? LicensePlateListSourceId { get; set; }

    public string? DriverDataTrafficCode { get; set; }

    public string? DriverDataLicenseNumber { get; set; }

    public int? DriverDataLicenseCategoryId { get; set; }
}
