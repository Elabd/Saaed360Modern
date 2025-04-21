using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityArea
{
    public long ActivityAreaId { get; set; }

    public Guid ActivityAreaGuid { get; set; }

    public string? ActivityAreaDescription { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long AreaId { get; set; }

    public Guid AreaGuid { get; set; }

    public long SourceId { get; set; }

    public int AreaInvolvementId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Area Area { get; set; } = null!;

    public virtual AreaInvolvementDim AreaInvolvement { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
