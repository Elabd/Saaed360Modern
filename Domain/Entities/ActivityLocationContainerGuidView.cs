using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityLocationContainerGuidView
{
    public Guid ActivityLocationGuid { get; set; }

    public string ActivityLocationDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid LocationGuid { get; set; }

    public string? SourceName { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
