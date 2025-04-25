using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class LocationComment
{
    public long LocationCommentId { get; set; }

    public Guid LocationCommentGuid { get; set; }

    public string LocationCommentDescription { get; set; } = null!;

    public long LocationId { get; set; }

    public Guid LocationGuid { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public int CommentInvolvementId { get; set; }

    public long SourceId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim CommentInvolvement { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Location Location { get; set; } = null!;

    public virtual Person? ModifiedByNavigation { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
