using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CaseCharge
{
    public long CaseChargeId { get; set; }

    public Guid CaseChargeGuid { get; set; }

    public string Description { get; set; } = null!;

    public long SourceId { get; set; }

    public long ChargeId { get; set; }

    public Guid ChargeGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Charge Charge { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
