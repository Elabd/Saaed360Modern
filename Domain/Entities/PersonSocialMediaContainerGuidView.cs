using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSocialMediaContainerGuidView
{
    public Guid PersonSocialMediaGuid { get; set; }

    public string PersonSocialMediaDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public string? SocialMediaInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
