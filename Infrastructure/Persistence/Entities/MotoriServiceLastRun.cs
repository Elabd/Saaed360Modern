using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class MotoriServiceLastRun
{
    public int Id { get; set; }

    public DateTime LastRunTime { get; set; }

    public long LastReportId { get; set; }
}

