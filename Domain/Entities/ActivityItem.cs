using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityItem
{
    public long ActivityItemId { get; set; }

    public Guid ActivityItemGuid { get; set; }

    public string ActivityItemDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long SourceId { get; set; }

    public int ItemInvolvementId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CurrentStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ICollection<ActivityItemStatusLocation> ActivityItemStatusLocations { get; set; } = new List<ActivityItemStatusLocation>();

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ActivityItemStatusDim? CurrentStatus { get; set; }

    public virtual Item Item { get; set; } = null!;

    public virtual ItemInvolvementDim ItemInvolvement { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
