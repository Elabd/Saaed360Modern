using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseChargeContainerView
{
    public long CaseChargeId { get; set; }

    public string Description { get; set; } = null!;

    public string? SourceName { get; set; }

    public long ChargeId { get; set; }

    public long ActivityId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
