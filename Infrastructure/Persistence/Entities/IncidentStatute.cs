using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentStatute
{
    public long IncidentStatuteId { get; set; }

    public Guid IncidentStatuteGuid { get; set; }

    public string IncidentStatuteDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int StatuteId { get; set; }

    public int StatuteSeverityId { get; set; }

    public bool IsAttempted { get; set; }

    public bool IsConspiracy { get; set; }

    public bool IsSolicited { get; set; }

    public bool IsGangCrime { get; set; }

    public bool IsArmed { get; set; }

    public bool IsHateCrime { get; set; }

    public bool IsDomesticViolence { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual StatuteDim Statute { get; set; } = null!;

    public virtual StatuteSeverityDim StatuteSeverity { get; set; } = null!;
}
