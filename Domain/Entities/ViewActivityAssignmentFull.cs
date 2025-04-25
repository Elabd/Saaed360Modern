using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityAssignmentFull
{
    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public long DispatcherId { get; set; }

    public long TrafficExpertId { get; set; }
}
