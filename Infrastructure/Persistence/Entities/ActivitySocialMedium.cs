using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivitySocialMedium
{
    public long ActivitySocialMediaId { get; set; }

    public Guid ActivitySocialMediaGuid { get; set; }

    public string ActivitySocialMediaDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public int SocialMediaInvolvementId { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual SocialMediaInvolvementDim SocialMediaInvolvement { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
