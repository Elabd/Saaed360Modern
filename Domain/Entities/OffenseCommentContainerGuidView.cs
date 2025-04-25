using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCommentContainerGuidView
{
    public Guid OffenseCommentGuid { get; set; }

    public string OffenseCommentDescription { get; set; } = null!;

    public Guid ActivityGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
