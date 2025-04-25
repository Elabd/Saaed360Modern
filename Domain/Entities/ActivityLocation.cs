using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityLocation
{
    public long ActivityLocationId { get; set; }

    public Guid ActivityLocationGuid { get; set; }

    public string ActivityLocationDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long SourceId { get; set; }

    public int LocationInvolvementId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual LocationInvolvementDim LocationInvolvement { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
