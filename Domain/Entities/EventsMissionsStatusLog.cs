using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsMissionsStatusLog
{
    public long EventStatusLogId { get; set; }

    public long? MissionId { get; set; }

    public int? EventMissionStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventsMissionStatusDim? EventMissionStatus { get; set; }

    public virtual EventsMission? Mission { get; set; }
}
