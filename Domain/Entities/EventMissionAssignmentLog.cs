using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventMissionAssignmentLog
{
    public long EventMissionAssignmentLogId { get; set; }

    public long? MissionAssignId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public long? Createdby { get; set; }

    public virtual Person? CreatedbyNavigation { get; set; }

    public virtual EventsMissionAssignment? MissionAssign { get; set; }

    public virtual EventMissionAssignmentStatusDim? Status { get; set; }
}
