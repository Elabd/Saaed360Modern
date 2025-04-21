using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportVehicleDatawithCode
{
    public Guid? Id { get; set; }

    public long ReportId { get; set; }

    public string? ReportNumber { get; set; }

    public string Reportcode { get; set; } = null!;

    public int VehicleDataId { get; set; }

    public int? VehicleDataTypeId { get; set; }

    public string? PlateNumber { get; set; }

    public string? MobileNumber { get; set; }

    public string? InsuranceCompany { get; set; }

    public string? Role { get; set; }
}
