using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeCommentContainerGuidView
{
    public Guid ChargeCommentGuid { get; set; }

    public string ChargeCommentDescription { get; set; } = null!;

    public Guid ChargeGuid { get; set; }

    public Guid CommentGuid { get; set; }

    public string? SourceName { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? RowStatusCode { get; set; }
}
