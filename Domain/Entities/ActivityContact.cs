using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityContact
{
    public long ActivityContactId { get; set; }

    public Guid ActivityContactGuid { get; set; }

    public string ActivityContactDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public int ContactInvolvementId { get; set; }

    public Guid ContactGuid { get; set; }

    public long ContactId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long ActivityId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactInvolvementDim ContactInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
