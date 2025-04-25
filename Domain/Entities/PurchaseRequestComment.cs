using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PurchaseRequestComment
{
    public long PurchaseRequestCommentId { get; set; }

    public long PurchaseRequestId { get; set; }

    public string Comment { get; set; } = null!;

    public long PersonId { get; set; }

    public int StatusId { get; set; }

    public DateTime CommentDate { get; set; }

    public virtual Person Person { get; set; } = null!;

    public virtual PurchaseRequest PurchaseRequest { get; set; } = null!;

    public virtual PurchaseRequestStatus Status { get; set; } = null!;
}
