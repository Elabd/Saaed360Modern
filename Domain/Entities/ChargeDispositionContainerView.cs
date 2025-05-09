using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeDispositionContainerView
{
    public long ChargeDispositionId { get; set; }

    public string ChargeDispositionDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long ChargeId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
