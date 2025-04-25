using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OrganizationCommentContainerGuidView
{
    public Guid OrganizationCommentGuid { get; set; }

    public string OrganizationCommentDescription { get; set; } = null!;

    public Guid OrganizationGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
