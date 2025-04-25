using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class GetReportDetailsDatum
{
    public string? ReportNumber { get; set; }

    public DateTime ReportDateTime { get; set; }

    public int? IsOwnFault { get; set; }

    public int? InsuranceTypeId { get; set; }

    public string? InsuranceType { get; set; }

    public int? DescreptionId { get; set; }

    public string? Description { get; set; }

    public string? DescriptionOther { get; set; }

    public int? AccidentReasonId { get; set; }

    public string? AccidentReason { get; set; }

    public string? AccidentReasonOther { get; set; }

    public string? PlateNo { get; set; }

    public string? ReportType { get; set; }

    public string? OwnerTcf { get; set; }

    public string? DriverTcf { get; set; }

    public string? ChasisNumber { get; set; }

    public string? DamagedPartsDetails { get; set; }

    public string? DamagePartsDescription { get; set; }

    public int AccidentTypeId { get; set; }

    public string? AccidentType { get; set; }

    public string? AccidentTypeOther { get; set; }
}
