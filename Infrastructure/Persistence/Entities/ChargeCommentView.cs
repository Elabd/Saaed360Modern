using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ChargeCommentView
{
    public long CommentId { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? CommentCategoryDescription { get; set; }

    public string? CommentCategoryCode { get; set; }

    public string? CommentName { get; set; }

    public string? CommentFormatted { get; set; }

    public string? CommentPlain { get; set; }

    public string? ImportanceHighLowCode { get; set; }

    public string? ImportanceHighLowDescription { get; set; }

    public string? PriorityHighLowCode { get; set; }

    public string? PriorityHighLowDescription { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public bool? ActiveIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public string? RowStatusDescription { get; set; }

    public long ChargeCommentId { get; set; }

    public string ChargeCommentDescription { get; set; } = null!;

    public long ChargeId { get; set; }
}
