using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IdentityTheftIncident
{
    public long ActivityId { get; set; }

    public int IdentityTheftCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual IdentityTheftCategoryDim IdentityTheftCategory { get; set; } = null!;
}

