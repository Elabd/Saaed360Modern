using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonCommentNew01
{
    public long PersonCommentId { get; set; }

    public Guid PersonCommentGuid { get; set; }

    public string PersonCommentDescription { get; set; } = null!;

    public long PersonId { get; set; }

    public Guid PersonGuid { get; set; }

    public long CommentId { get; set; }

    public Guid CommentGuid { get; set; }

    public long SourceId { get; set; }

    public int? CommentInvolvementId { get; set; }

    public DateTime? CreateDateTimeStamp { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public bool? IsDeleted { get; set; }

    public int? RowStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public long? ModifiedBy { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual Comment Comment { get; set; } = null!;

    public virtual CommentInvolvementDim? CommentInvolvement { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual Source Source { get; set; } = null!;
}
