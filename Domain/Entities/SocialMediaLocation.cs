using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaLocation
{
    public long SocialMediaLocationId { get; set; }

    public Guid SocialMediaLocationGuid { get; set; }

    public string SocialMediaLocationDescription { get; set; } = null!;

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long SourceId { get; set; }

    public int LocationInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim LocationInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
