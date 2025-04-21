using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonLocationContainerView
{
    public long PersonLocationId { get; set; }

    public string PersonLocationDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long LocationId { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public string? LocationInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public bool? IsPrimary { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
