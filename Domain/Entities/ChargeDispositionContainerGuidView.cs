using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeDispositionContainerGuidView
{
    public Guid ChargeDispositionGuid { get; set; }

    public string ChargeDispositionDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid ChargeGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
