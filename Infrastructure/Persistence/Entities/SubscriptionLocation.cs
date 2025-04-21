using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionLocation
{
    public long SubscriptionLocationId { get; set; }

    public Guid SubscriptionLocationGuid { get; set; }

    public string SubscriptionLocationDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public int LocationInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim LocationInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;
}
