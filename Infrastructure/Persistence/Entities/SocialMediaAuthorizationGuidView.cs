using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SocialMediaAuthorizationGuidView
{
    public Guid SocialMediaAuthorizationGuid { get; set; }

    public string SocialMediaAuthorizationDescription { get; set; } = null!;

    public Guid SocialMediaGuid { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? Value { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
