using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Disposition
{
    public long ActivityId { get; set; }

    public int? DispositionCategoryId { get; set; }

    public int? DispositionReasonId { get; set; }

    public DateTime? DispositionDate { get; set; }

    public string? Description { get; set; }

    public string? ResultDescription { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual DispositionCategoryDim? DispositionCategory { get; set; }

    public virtual DispositionReasonDim? DispositionReason { get; set; }
}
