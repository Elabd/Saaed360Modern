using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LocationContactContainerGuidView
{
    public Guid LocationContactGuid { get; set; }

    public string LocationContactDescription { get; set; } = null!;

    public Guid LocationGuid { get; set; }

    public Guid ContactGuid { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
