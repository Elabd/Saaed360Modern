using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class FmsexcludedBranch
{
    public long Id { get; set; }

    public Guid? BranchId { get; set; }
}
