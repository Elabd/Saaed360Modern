using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TrackingHelpView
{
    public long ActivityId { get; set; }

    public long? ActivityItemStatusId { get; set; }

    public int ActivityStatusId { get; set; }

    public int? ActivityTransactionStatusId { get; set; }

    public double? AccidentLatitude { get; set; }

    public double? AccidentLongitude { get; set; }

    public string? PatrolName { get; set; }

    public double? PatrolLatitude { get; set; }

    public double? PatrolLongitude { get; set; }
}
