using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VTrafficViolation
{
    public long ViolationId { get; set; }

    public int ReportId { get; set; }

    public long TrafficExpertId { get; set; }

    public int ViolationStatusId { get; set; }

    public string ViolationStatusCode { get; set; } = null!;

    public string TechnicalSupportViolationStatusEn { get; set; } = null!;

    public string TechnicalSupportViolationStatusAr { get; set; } = null!;

    public string? PoliceViolationStatusEn { get; set; }

    public string? PoliceViolationStatusAr { get; set; }

    public int ViolationTypeId { get; set; }

    public string ViolationTypeCode { get; set; } = null!;

    public string ViolationTypeAr { get; set; } = null!;

    public string ViolationTypeEn { get; set; } = null!;

    public DateTime? ReportDate { get; set; }

    public string? ReportNumber { get; set; }

    public string? PlateNumber { get; set; }

    public int? PlateSourceId { get; set; }

    public string? PlateSourceAr { get; set; }

    public string? PlateSourceEn { get; set; }

    public int PlateColorId { get; set; }

    public string? PlateColorAr { get; set; }

    public string? PlateColorEn { get; set; }

    public string? TrafficExpertName { get; set; }

    public string TrafficExpertCode { get; set; } = null!;

    public string? TrafficExpertMobileNumber { get; set; }

    public bool IsPoliceStatus { get; set; }
}
