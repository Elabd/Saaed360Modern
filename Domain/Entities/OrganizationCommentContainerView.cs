using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationCommentContainerView
{
    public long OrganizationCommentId { get; set; }

    public string OrganizationCommentDescription { get; set; } = null!;

    public long OrganizationId { get; set; }

    public long CommentId { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? CommentInvolvementDescription { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }
}
