using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeComment
{
    public long ChargeCommentId { get; set; }

    public Guid ChargeCommentGuid { get; set; }

    public string ChargeCommentDescription { get; set; } = null!;

    public long ChargeId { get; set; }

    public Guid ChargeGuid { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Charge Charge { get; set; } = null!;

    public virtual Comment Comment { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
