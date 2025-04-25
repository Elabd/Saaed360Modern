using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccincidentLog
{
    public long Id { get; set; }

    public long IncidentRequestId { get; set; }

    public long? PersonId { get; set; }

    public long? PatrolId { get; set; }

    public int? OldStatus { get; set; }

    public int NewStatus { get; set; }

    public string? Notes { get; set; }

    public DateTime LogDateTime { get; set; }

    public virtual IcccincidentRequest IncidentRequest { get; set; } = null!;

    public virtual SmartDispatchingIncidentStatusDim NewStatusNavigation { get; set; } = null!;

    public virtual SmartDispatchingIncidentStatusDim? OldStatusNavigation { get; set; }

    public virtual Item? Patrol { get; set; }

    public virtual Person? Person { get; set; }
}
