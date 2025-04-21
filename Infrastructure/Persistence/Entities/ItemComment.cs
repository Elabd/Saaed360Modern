using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ItemComment
{
    public long ItemCommentId { get; set; }

    public Guid ItemCommentGuid { get; set; }

    public string ItemCommentDescription { get; set; } = null!;

    public long ItemId { get; set; }

    public Guid ItemGuid { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public int CommentInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim CommentInvolvement { get; set; } = null!;

    public virtual Item Item { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
