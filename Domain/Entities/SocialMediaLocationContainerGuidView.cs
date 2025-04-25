using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaLocationContainerGuidView
{
    public Guid SocialMediaLocationGuid { get; set; }

    public string SocialMediaLocationDescription { get; set; } = null!;

    public Guid SocialMediaGuid { get; set; }

    public Guid LocationGuid { get; set; }

    public string? SourceName { get; set; }

    public string? LocationInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
