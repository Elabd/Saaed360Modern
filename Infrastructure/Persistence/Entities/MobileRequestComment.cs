using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MobileRequestComment
{
    public long CommentId { get; set; }

    public string CommentDescription { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public long PersonId { get; set; }

    public long MobileRequestId { get; set; }

    public DateTime CreationDate { get; set; }

    public virtual MobileRequest MobileRequest { get; set; } = null!;
}
