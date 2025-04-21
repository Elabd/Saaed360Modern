using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationSocialMedium
{
    public long OrganizationSocialMediaId { get; set; }

    public Guid OrganizationSocialMediaGuid { get; set; }

    public string OrganizationSocialMediaDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public int SocialMediaInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual SocialMediaInvolvementDim SocialMediaInvolvement { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
