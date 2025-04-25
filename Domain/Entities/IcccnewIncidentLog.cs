using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccnewIncidentLog
{
    public long Id { get; set; }

    public string IcccincidentNumber { get; set; } = null!;

    public long IcccincidentRequestId { get; set; }
}
