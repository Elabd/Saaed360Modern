using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityContactContainerGuidView
{
    public Guid ActivityContactGuid { get; set; }

    public string ActivityContactDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public Guid ContactGuid { get; set; }

    public Guid ActivityGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
