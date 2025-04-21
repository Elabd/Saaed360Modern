using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ContactCommentContainerView
{
    public long ContactCommentId { get; set; }

    public string ContactCommentDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? CommentInvolvementDescription { get; set; }

    public long CommentId { get; set; }

    public long ContactId { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
