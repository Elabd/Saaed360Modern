using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AuditDetail
{
    public long AuditDetailId { get; set; }

    public Guid AuditDetailGuid { get; set; }

    public string AuditDetailDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public int? AuditCategoryId { get; set; }

    public string? AuditXml { get; set; }

    public DateTime? AuditDateTime { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual AuditCategoryDim? AuditCategory { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
