using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FmssubBranchUser
{
    public long Id { get; set; }

    public Guid FmssubBranchId { get; set; }

    public long UserId { get; set; }

    public virtual Person User { get; set; } = null!;
}
