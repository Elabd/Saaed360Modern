using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewIncidentDelayStatus
{
    public long IncidentId { get; set; }

    public DateTime? IncidentCreatedDate { get; set; }

    public int StatusId { get; set; }

    public int? ServiceCallPriorityId { get; set; }

    public string? IncidentDelayStatus { get; set; }
}
