using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationSocialMediaContainerGuidView
{
    public Guid OrganizationSocialMediaGuid { get; set; }

    public string OrganizationSocialMediaDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public Guid OrganizationGuid { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
