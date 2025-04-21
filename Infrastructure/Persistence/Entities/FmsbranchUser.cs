using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FmsbranchUser
{
    public long Id { get; set; }

    public Guid FmsbranchId { get; set; }

    public long UserId { get; set; }

    public virtual Person User { get; set; } = null!;
}
