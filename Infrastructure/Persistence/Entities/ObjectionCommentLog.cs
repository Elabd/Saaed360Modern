using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ObjectionCommentLog
{
    public long ObjectionCommentLogId { get; set; }

    public long ObjectionId { get; set; }

    public string CommentText { get; set; } = null!;

    public long PersonId { get; set; }

    public DateTime CreationTime { get; set; }

    public virtual Objection Objection { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
