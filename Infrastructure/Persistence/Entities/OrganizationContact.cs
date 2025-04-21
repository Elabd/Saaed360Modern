using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OrganizationContact
{
    public long OrganizationContactId { get; set; }

    public Guid OrganizationContactGuid { get; set; }

    public string OrganizationContactDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public long Contactid { get; set; }

    public Guid ContactGuid { get; set; }

    public long OrganizationId { get; set; }

    public Guid OrganizationGuid { get; set; }

    public int ContactInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public int? RowStatusId { get; set; }

    public bool IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactInvolvementDim ContactInvolvement { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
