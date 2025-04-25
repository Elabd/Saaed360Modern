using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CitationViolation
{
    public long CitationViolationId { get; set; }

    public Guid CitationViolationGuid { get; set; }

    public string? CitationViolationDescription { get; set; }

    public long ActivityId { get; set; }

    public Guid ActivityGuid { get; set; }

    public long SourceId { get; set; }

    public string? Observation { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public DateTime? ViolationDateTimeStamp { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ActivityComment Comment { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
