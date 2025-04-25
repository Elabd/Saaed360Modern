using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationCommentContainerView
{
    public long LocationCommentId { get; set; }

    public string LocationCommentDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public long CommentId { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? CommentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
