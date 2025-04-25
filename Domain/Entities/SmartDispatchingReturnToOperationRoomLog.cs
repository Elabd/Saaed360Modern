using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SmartDispatchingReturnToOperationRoomLog
{
    public long Id { get; set; }

    public long IncidentRequestId { get; set; }

    public long PersonId { get; set; }

    public long PatrolId { get; set; }

    public int ReasonId { get; set; }

    public string? ReasonDescription { get; set; }

    public DateTime LogDateTime { get; set; }

    public virtual IcccincidentRequest IncidentRequest { get; set; } = null!;

    public virtual Item Patrol { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual IncidentReturnToOrreasonsDim Reason { get; set; } = null!;
}
