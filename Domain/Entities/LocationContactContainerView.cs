using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationContactContainerView
{
    public long LocationContactId { get; set; }

    public string LocationContactDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public long ContactId { get; set; }

    public string? ContactInvolvementCode { get; set; }

    public string? ContactInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
