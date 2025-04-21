using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaeedLog
{
    public int LogId { get; set; }

    public string? LogDetails { get; set; }

    public string? LogType { get; set; }
}
