using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CaseChargeContainerGuidView
{
    public Guid CaseChargeGuid { get; set; }

    public string Description { get; set; } = null!;

    public string? SourceName { get; set; }

    public Guid ChargeGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
