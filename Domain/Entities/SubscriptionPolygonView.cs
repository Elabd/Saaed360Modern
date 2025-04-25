using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionPolygonView
{
    public long SubscriptionPolygonId { get; set; }

    public string SubscriptionPolygonDescription { get; set; } = null!;

    public long Subscriptionid { get; set; }

    public string? SubscriptionPolygonCategoryCode { get; set; }

    public string? SubscriptionPolygonCategoryDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public long PolygonIdentifier { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
