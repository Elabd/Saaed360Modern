using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CommunityService
{
    public long ActivityId { get; set; }

    public int CommunityServiceCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CommunityServiceCategoryDim CommunityServiceCategory { get; set; } = null!;
}

