using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityAssignmentDelayReason
{
    public long ActivityId { get; set; }

    public int ActivityReasonId { get; set; }
}
