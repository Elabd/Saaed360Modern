using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ArrestChargeContainerGuidView
{
    public Guid ArrestChargeGuid { get; set; }

    public string ArrestChargeDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid ChargeGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
