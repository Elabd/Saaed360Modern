using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficViolationRejectionReason
{
    public long Id { get; set; }

    public long ViolationId { get; set; }

    public string Reason { get; set; } = null!;

    public DateTime CreationDate { get; set; }

    public long CreatedBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public long? ModifiedBy { get; set; }

    public virtual Person CreatedByNavigation { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual TrafficViolation Violation { get; set; } = null!;
}
