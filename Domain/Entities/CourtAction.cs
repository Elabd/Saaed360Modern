using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtAction
{
    public long ActivityId { get; set; }

    public int CourtActionCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CourtActionCategoryDim CourtActionCategory { get; set; } = null!;
}
