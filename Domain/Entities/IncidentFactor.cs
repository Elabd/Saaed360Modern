using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentFactor
{
    public long IncidentFactorId { get; set; }

    public Guid IncidentFactorGuid { get; set; }

    public string IncidentFactorDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? FactorId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual IncidentFactorDim? Factor { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
