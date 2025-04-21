using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentStatuteView
{
    public long IncidentStatuteId { get; set; }

    public string IncidentStatuteDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public string? StatuteCode { get; set; }

    public string? StatuteDescription { get; set; }

    public string? StatuteStatuteDescription { get; set; }

    public string? StatuteSeverityCode { get; set; }

    public string? StatuteSeverityDescription { get; set; }

    public bool IsAttempted { get; set; }

    public bool IsConspiracy { get; set; }

    public bool IsSolicited { get; set; }

    public bool IsGangCrime { get; set; }

    public bool IsArmed { get; set; }

    public bool IsHateCrime { get; set; }

    public bool IsDomesticViolence { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
