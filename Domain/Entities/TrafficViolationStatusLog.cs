using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficViolationStatusLog
{
    public long Id { get; set; }

    public long ViolationId { get; set; }

    public int? OldStatus { get; set; }

    public int NewStatus { get; set; }

    public DateTime CreationDate { get; set; }

    public long? CreatedBy { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual TrafficViolationStatusDim NewStatusNavigation { get; set; } = null!;

    public virtual TrafficViolationStatusDim? OldStatusNavigation { get; set; }

    public virtual TrafficViolation Violation { get; set; } = null!;
}
