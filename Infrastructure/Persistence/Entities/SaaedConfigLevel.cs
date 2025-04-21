using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedConfigLevel
{
    public string? Description { get; set; }

    public double DelayTimeSpan { get; set; }

    public string? WorkflowName { get; set; }
}
