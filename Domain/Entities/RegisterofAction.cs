using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class RegisterofAction
{
    public long ActivityId { get; set; }

    public int RegisterofActionCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual RegisterofActionCategoryDim RegisterofActionCategory { get; set; } = null!;
}
