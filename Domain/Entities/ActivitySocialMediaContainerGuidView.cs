using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivitySocialMediaContainerGuidView
{
    public Guid ActivitySocialMediaGuid { get; set; }

    public string ActivitySocialMediaDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public Guid ActivityGuid { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
