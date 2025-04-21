using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VGetIncidentReason
{
    public long ActivityId { get; set; }

    public long Area { get; set; }

    public long Emirate { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public int StatusId { get; set; }

    public int ActivityCategoryId { get; set; }

    public int? ReasonCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public int ActivityReasonId { get; set; }

    public string? Reason { get; set; }
}
