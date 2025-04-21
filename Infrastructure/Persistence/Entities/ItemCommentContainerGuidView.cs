using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemCommentContainerGuidView
{
    public Guid ItemCommentGuid { get; set; }

    public string ItemCommentDescription { get; set; } = null!;

    public Guid ItemGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
