using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionLocationContainerView
{
    public long SubscriptionLocationId { get; set; }

    public string SubscriptionLocationDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public long LocationId { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? LocationInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
