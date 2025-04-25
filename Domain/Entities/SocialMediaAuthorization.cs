using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaAuthorization
{
    public long SocialMediaAuthorizationId { get; set; }

    public Guid SocialMediaAuthorizationGuid { get; set; }

    public string SocialMediaAuthorizationDescription { get; set; } = null!;

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public long SourceId { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? Value { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
