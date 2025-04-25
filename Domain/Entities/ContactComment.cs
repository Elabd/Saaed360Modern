using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ContactComment
{
    public long ContactCommentId { get; set; }

    public Guid ContactCommentGuid { get; set; }

    public string ContactCommentDescription { get; set; } = null!;

    public long SourceId { get; set; }

    public int CommentInvolvementId { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public long ContactId { get; set; }

    public Guid ContactGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim CommentInvolvement { get; set; } = null!;

    public virtual Contact Contact { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
