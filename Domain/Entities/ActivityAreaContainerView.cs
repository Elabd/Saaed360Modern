using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityAreaContainerView
{
    public long ActivityAreaId { get; set; }

    public string? ActivityAreaDescription { get; set; }

    public long ActivityId { get; set; }

    public long AreaId { get; set; }

    public string? SourceName { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public string? AreaInvolvementDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
