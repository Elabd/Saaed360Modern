using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportAccessChannel
{
    public int ReportAccessChannelId { get; set; }

    public string ReportChannelDesc { get; set; } = null!;
}
