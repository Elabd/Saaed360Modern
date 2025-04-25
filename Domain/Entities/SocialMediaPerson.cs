using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaPerson
{
    public long SocialMediaPersonId { get; set; }

    public Guid SocialMediaPersonGuid { get; set; }

    public string SocialMediaPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long SocialMediaId { get; set; }

    public long SourceId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public int PersonInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonInvolvementDim PersonInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
