using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityTask
{
    public long Id { get; set; }

    public long? TaskId { get; set; }

    public long? ActivityId { get; set; }

    public long? TaskInvolvementId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual Task? Task { get; set; }

    public virtual TaskInvolvementDim? TaskInvolvement { get; set; }
}
