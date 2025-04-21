using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArrestChargeContainerView
{
    public long ArrestChargeId { get; set; }

    public string ArrestChargeDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long ChargeId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
