using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactCommentContainerGuidView
{
    public Guid ContactCommentGuid { get; set; }

    public string ContactCommentDescription { get; set; } = null!;

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public Guid CommentGuid { get; set; }

    public Guid ContactGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
