using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactCommentGuidView
{
    public Guid CommentGuid { get; set; }

    public string? OriginalIdent { get; set; }

    public string? SourceName { get; set; }

    public string? CommentCategoryCode { get; set; }

    public string? CommentName { get; set; }

    public string? CommentFormatted { get; set; }

    public string? CommentPlain { get; set; }

    public string? ImportanceHighLowCode { get; set; }

    public string? PriorityHighLowCode { get; set; }

    public DateTime? EntryDateTime { get; set; }

    public bool? ActiveIndicator { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public string? RowStatusCode { get; set; }

    public Guid ContactCommentGuid { get; set; }

    public string ContactCommentDescription { get; set; } = null!;

    public string? CommentInvolvementCode { get; set; }

    public Guid ContactGuid { get; set; }
}
