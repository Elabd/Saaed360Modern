using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SocialMediaAuthorizationView
{
    public long SocialMediaAuthorizationId { get; set; }

    public string SocialMediaAuthorizationDescription { get; set; } = null!;

    public long SocialMediaId { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? Value { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
