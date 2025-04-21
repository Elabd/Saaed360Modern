using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccintegrationLog
{
    public long Id { get; set; }

    public string IcccincidentNumber { get; set; } = null!;

    public string Exception { get; set; } = null!;

    public int ExceptionSource { get; set; }

    public string Method { get; set; } = null!;

    public DateTime LoggedTime { get; set; }
}
