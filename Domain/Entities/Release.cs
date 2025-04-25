using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Release
{
    public long ActivityId { get; set; }

    public int ReleaseReasonId { get; set; }

    public int ReleaseAuthorizationCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual ReleaseAuthorizationCategoryDim ReleaseAuthorizationCategory { get; set; } = null!;

    public virtual ReleaseReasonDim ReleaseReason { get; set; } = null!;
}
