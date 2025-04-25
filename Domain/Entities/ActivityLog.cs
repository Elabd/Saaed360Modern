using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityLog
{
    public long ActivityLogId { get; set; }

    public long ActivityId { get; set; }

    public string? PropertyName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public DateTime? FromDateTimeStamp { get; set; }

    public DateTime? ToDateTimeStamp { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
