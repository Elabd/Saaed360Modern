using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class SaaedLog
{
    public long LogId { get; set; }

    public string? LogDetails { get; set; }

    public string? LogType { get; set; }

    public DateTime LoggedTime { get; set; }

    public string? ClassName { get; set; }

    public string? MethodName { get; set; }
}
