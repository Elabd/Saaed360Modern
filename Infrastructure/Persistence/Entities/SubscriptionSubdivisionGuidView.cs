using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionSubdivisionGuidView
{
    public Guid SubscriptionSubdivisionGuid { get; set; }

    public string SubscriptionSubdivisionDescription { get; set; } = null!;

    public Guid SubscriptionGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
