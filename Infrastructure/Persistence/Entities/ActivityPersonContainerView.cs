using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityPersonContainerView
{
    public long ActivityPersonId { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long ActivityId { get; set; }

    public string? SourceName { get; set; }

    public string? PersonInvolvementCode { get; set; }

    public string? PersonInvolvementDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
