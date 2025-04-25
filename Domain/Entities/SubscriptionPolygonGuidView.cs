using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionPolygonGuidView
{
    public Guid SubscriptionPolygonGuid { get; set; }

    public string SubscriptionPolygonDescription { get; set; } = null!;

    public Guid SubscriptionGuid { get; set; }

    public string? SubscriptionPolygonCategoryCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public long PolygonIdentifier { get; set; }

    public string? RowStatusCode { get; set; }
}
