using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class OffenseCommentView
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

    public long OffenseCommentId { get; set; }

    public string OffenseCommentDescription { get; set; } = null!;

    public long ActivityId { get; set; }
}
