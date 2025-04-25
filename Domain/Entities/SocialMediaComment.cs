using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SocialMediaComment
{
    public long SocialMediaCommentId { get; set; }

    public Guid SocialMediaCommentGuid { get; set; }

    public string Description { get; set; } = null!;

    public long SocialMediaId { get; set; }

    public Guid SocialMediaGuid { get; set; }

    public long SourceId { get; set; }

    public int CommentInvolvementId { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public DateTime CreateDateTimeStamp { get; set; }

    public DateTime ModifiedDateTimeStamp { get; set; }

    public bool IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim CommentInvolvement { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual SocialMedium SocialMedia { get; set; } = null!;

    public virtual Source Source { get; set; } = null!;
}
