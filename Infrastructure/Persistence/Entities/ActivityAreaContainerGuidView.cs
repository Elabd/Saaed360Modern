using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityAreaContainerGuidView
{
    public Guid ActivityAreaGuid { get; set; }

    public string? ActivityAreaDescription { get; set; }

    public Guid ActivityGuid { get; set; }

    public Guid AreaGuid { get; set; }

    public string? SourceName { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
