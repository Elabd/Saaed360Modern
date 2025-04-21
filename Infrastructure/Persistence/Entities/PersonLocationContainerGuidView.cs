using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonLocationContainerGuidView
{
    public Guid PersonLocationGuid { get; set; }

    public string PersonLocationDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid LocationGuid { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
