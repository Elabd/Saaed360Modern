using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Docket
{
    public long ActivityId { get; set; }

    public int DocketCategoryId { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual DocketCategoryDim DocketCategory { get; set; } = null!;
}
