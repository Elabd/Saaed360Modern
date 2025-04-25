using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCommentContainerView
{
    public long OffenseCommentId { get; set; }

    public string OffenseCommentDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long CommentId { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
