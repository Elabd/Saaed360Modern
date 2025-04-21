using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivitySubscriptionContainerGuidView
{
    public Guid ActivitySubscriptionGuid { get; set; }

    public string ActivitySubscriptionDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public string? SourceName { get; set; }

    public string? SubscriptionInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
