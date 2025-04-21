using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonCommentContainerGuidView
{
    public Guid PersonCommentGuid { get; set; }

    public string PersonCommentDescription { get; set; } = null!;

    public Guid PersonGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? SourceName { get; set; }

    public string? CommentInvolvementCode { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
