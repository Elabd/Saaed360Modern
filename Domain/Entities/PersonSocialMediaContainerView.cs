using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSocialMediaContainerView
{
    public long PersonSocialMediaId { get; set; }

    public string PersonSocialMediaDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public long SocialMediaId { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SocialMediaInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
