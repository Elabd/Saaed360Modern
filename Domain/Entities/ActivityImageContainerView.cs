using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityImageContainerView
{
    public long ActivityImageId { get; set; }

    public string ActivityImageDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long ImageId { get; set; }

    public string? SourceName { get; set; }

    public string? ImageInvolvementCode { get; set; }

    public string? ImageInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
