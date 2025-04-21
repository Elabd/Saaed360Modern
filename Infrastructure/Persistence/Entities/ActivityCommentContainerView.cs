using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ActivityCommentContainerView
{
    public long ActivityCommentId { get; set; }

    public string ActivityCommentDescription { get; set; } = null!;

    public long ActivityId { get; set; }

    public long CommentId { get; set; }

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? CommentInvolvementDescription { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
