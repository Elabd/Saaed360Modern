using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FmsbranchOrder
{
    public long Id { get; set; }

    public int BranchOrder { get; set; }

    public Guid? BranchId { get; set; }
}
