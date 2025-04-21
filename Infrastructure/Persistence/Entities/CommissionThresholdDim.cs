using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CommissionThresholdDim
{
    public int CommissionThresholdId { get; set; }

    public int? Threshold { get; set; }

    public string? Description { get; set; }

    public bool? IsHotArea { get; set; }
}
