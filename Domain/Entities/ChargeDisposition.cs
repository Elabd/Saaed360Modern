using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeDisposition
{
    public long ChargeDispositionId { get; set; }

    public Guid ChargeDispositionGuid { get; set; }

    public string ChargeDispositionDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long ChargeId { get; set; }

    public Guid ChargeGuid { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Charge Charge { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
