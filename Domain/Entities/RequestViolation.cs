using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RequestViolation
{
    public long RequestViolationId { get; set; }

    public Guid RequestViolationGuid { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? RequestViolationCategoryId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RequestViolationCategoryDim? RequestViolationCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
