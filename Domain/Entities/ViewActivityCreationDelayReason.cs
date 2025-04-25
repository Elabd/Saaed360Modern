using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityCreationDelayReason
{
    public long ActivityId { get; set; }

    public int ActivityReasonId { get; set; }
}
