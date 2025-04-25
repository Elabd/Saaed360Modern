using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CourtEvent
{
    public long ActivityId { get; set; }

    public int CourtEventCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CourtEventCategoryDim CourtEventCategory { get; set; } = null!;
}
