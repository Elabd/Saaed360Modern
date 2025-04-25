using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonSocialMedium
{
    public long PersonSocialMediaId { get; set; }

    public Guid PersonSocialMediaGuid { get; set; }

    public string PersonSocialMediaDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public int SocialMediaInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual SocialMediaInvolvementDim SocialMediaInvolvement { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
