using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RoadAssistRequestComment
{
    public Guid CommentId { get; set; }

    public Guid CreatedByUserId { get; set; }

    public DateTime CreationDate { get; set; }

    public Guid? LastModifiedByUserId { get; set; }

    public DateTime? LastModificationDate { get; set; }

    public bool IsDeleted { get; set; }

    public string Text { get; set; } = null!;

    public Guid RequestId { get; set; }

    public virtual RoadAssistUser CreatedByUser { get; set; } = null!;

    public virtual RoadAssistUser? LastModifiedByUser { get; set; }

    public virtual RoadAssistRequest Request { get; set; } = null!;
}
