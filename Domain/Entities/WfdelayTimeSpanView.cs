using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class WfdelayTimeSpanView
{
    public double DelayTimeSpan { get; set; }

    public string Step { get; set; } = null!;

    public string Wf { get; set; } = null!;
}
