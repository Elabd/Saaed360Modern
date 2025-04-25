using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EscortMissionCancelationLog
{
    public long EscortMissionCancelationLogId { get; set; }

    public long EscortMissionId { get; set; }

    public long PatrolId { get; set; }

    public int? EscortRejectionReasonId { get; set; }

    public string? Note { get; set; }

    public int? EscortMissionCanclationConfirmationReasonId { get; set; }

    public long? CanceledBy { get; set; }

    public DateTime? CancelationDateTime { get; set; }

    public long? ConfirmedBy { get; set; }

    public DateTime? ConfirmationDateTime { get; set; }

    public long? EscortMissionPatrolId { get; set; }

    public virtual EscortCancelationConfirmationReasonDim? EscortMissionCanclationConfirmationReason { get; set; }

    public virtual EscortMissionPatrol? EscortMissionPatrol { get; set; }

    public virtual EscortRejectionReasonDim? EscortRejectionReason { get; set; }
}
