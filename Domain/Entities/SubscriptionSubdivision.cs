using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SubscriptionSubdivision
{
    public int SubscriptionSubdivisionId { get; set; }

    public Guid SubscriptionSubdivisionGuid { get; set; }

    public string SubscriptionSubdivisionDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public long SubscriptionId { get; set; }

    public Guid SubscriptionGuid { get; set; }

    public int GeoLocationSubDivisionId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual GeoLocationSubDivisionDim GeoLocationSubDivision { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;

    public virtual Subscription Subscription { get; set; } = null!;
}
