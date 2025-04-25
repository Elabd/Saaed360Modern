using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ActivityCommentContainerGuidView
{
    public Guid ActivityCommentGuid { get; set; }

    public string ActivityCommentDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
