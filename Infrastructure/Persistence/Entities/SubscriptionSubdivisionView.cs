using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SubscriptionSubdivisionView
{
    public int SubscriptionSubdivisionId { get; set; }

    public string SubscriptionSubdivisionDescription { get; set; } = null!;

    public long SubscriptionId { get; set; }

    public string? GeoLocationSubDivisionState { get; set; }

    public string? GeoLocationSubDivisionCounty { get; set; }

    public string? GeoLocationSubDivisionCity { get; set; }

    public string? GeoLocationSubDivisionSubDivision { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
