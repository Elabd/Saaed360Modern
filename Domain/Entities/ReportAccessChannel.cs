using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportAccessChannel
{
    public int ReportAccessChannelId { get; set; }

    public string ReportChannelDesc { get; set; } = null!;
}
