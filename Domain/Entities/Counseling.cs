using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Counseling
{
    public long ActivityId { get; set; }

    public int CounselingCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual CounselingCategoryDim CounselingCategory { get; set; } = null!;
}
