using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonContact
{
    public long PersonContactId { get; set; }

    public Guid PersonContactGuid { get; set; }

    public string PersonContactDescription { get; set; } = null!;

    public long ContactId { get; set; }

    public Guid ContactGuid { get; set; }

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public int ContactInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Contact Contact { get; set; } = null!;

    public virtual ContactInvolvementDim ContactInvolvement { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
