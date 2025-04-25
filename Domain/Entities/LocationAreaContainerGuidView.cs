using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationAreaContainerGuidView
{
    public Guid LocationAreaGuid { get; set; }

    public string LocationAreaDescription { get; set; } = null!;

    public Guid LocationGuid { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public Guid AreaGuid { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
