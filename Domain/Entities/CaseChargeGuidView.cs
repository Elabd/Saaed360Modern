using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseChargeGuidView
{
    public Guid ChargeGuid { get; set; }

    public string ChargeDescription { get; set; } = null!;

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public int? ChargeSequenceNumber { get; set; }

    public string? StatuteCode { get; set; }

    public string? ChargeDegreeCode { get; set; }

    public string? ChargeSeverityLevelCode { get; set; }

    public string? ChargeStatusCode { get; set; }

    public bool? FelonyIndicator { get; set; }

    public bool? SeriousViolentIndicator { get; set; }

    public DateTime? FillingDate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid CaseChargeGuid { get; set; }

    public string Description { get; set; } = null!;

    public Guid ActivityGuid { get; set; }
}
