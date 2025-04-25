using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityPerson
{
    public long ActivityPersonId { get; set; }

    public Guid ActivityPersonGuid { get; set; }

    public string ActivityPersonDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int PersonInvolvementId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PersonInvolvementDim PersonInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
