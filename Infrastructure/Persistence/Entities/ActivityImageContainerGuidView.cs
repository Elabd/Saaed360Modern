using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityImageContainerGuidView
{
    public Guid ActivityImageGuid { get; set; }

    public string ActivityImageDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid ImageGuid { get; set; }

    public string? SourceName { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
