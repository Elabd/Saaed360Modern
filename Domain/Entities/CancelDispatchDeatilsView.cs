using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CancelDispatchDeatilsView
{
    public long IncidentId { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public DateTime? CancelTime { get; set; }

    public int CancelReasonId { get; set; }

    public long? CanceledById { get; set; }

    public string CanceledByName { get; set; } = null!;

    public string? CancelReasonDescription { get; set; }

    public long OldDispatchId { get; set; }

    public long OldPatrolId { get; set; }

    public string? OldPatrolName { get; set; }
}
