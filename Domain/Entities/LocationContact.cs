using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationContact
{
    public long LocationContactId { get; set; }

    public Guid LocationContactGuid { get; set; }

    public string LocationContactDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long ContactId { get; set; }

    public Guid ContactGuid { get; set; }

    public int ContactInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactInvolvementDim ContactInvolvement { get; set; } = null!;

    public virtual Location Location { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
