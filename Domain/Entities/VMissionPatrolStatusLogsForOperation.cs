using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class VMissionPatrolStatusLogsForOperation
{
    public long EscortMissionPatrolStepId { get; set; }

    public long EscortMissionPatrolId { get; set; }

    public string? Status { get; set; }

    public string Person { get; set; } = null!;

    public DateTime? CreationDateTime { get; set; }
}
