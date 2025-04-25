using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationAreaContainerView
{
    public long LocationAreaId { get; set; }

    public string LocationAreaDescription { get; set; } = null!;

    public long Locationid { get; set; }

    public string? AreaInvolvementCode { get; set; }

    public string? AreaInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public long AreaId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
