using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityItemStatusLocation
{
    public long ActivityItemStatusLocationId { get; set; }

    public long ActivityItemId { get; set; }

    public long ActivityItemStatusId { get; set; }

    public long LocationId { get; set; }

    public DateTime DateTime { get; set; }

    public long? ChangedBy { get; set; }

    public virtual ActivityItem ActivityItem { get; set; } = null!;

    public virtual ActivityItemStatusDim ActivityItemStatus { get; set; } = null!;

    public virtual Person? ChangedByNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;
}
