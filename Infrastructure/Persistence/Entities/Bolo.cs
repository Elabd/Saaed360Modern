using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Bolo
{
    public long ActivityId { get; set; }

    public int? BoloCategoryId { get; set; }

    public int? PriorityHighLowId { get; set; }

    public string? Information { get; set; }

    public DateTime? EnteredDateTime { get; set; }

    public DateTime? ExpirationDateTime { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual BoloCategoryDim? BoloCategory { get; set; }

    public virtual HighLowDim? PriorityHighLow { get; set; }
}
