using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VwBranchesSaaed
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? ParentBranchId { get; set; }

    public string? ParentBranchName { get; set; }
}
