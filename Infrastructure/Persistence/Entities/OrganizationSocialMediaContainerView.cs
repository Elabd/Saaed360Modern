using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationSocialMediaContainerView
{
    public long OrganizationSocialMediaId { get; set; }

    public string OrganizationSocialMediaDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public long OrganizationId { get; set; }

    public long SocialMediaId { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SocialMediaInvolvementDescription { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
