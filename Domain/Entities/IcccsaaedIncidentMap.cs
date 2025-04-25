using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccsaaedIncidentMap
{
    public long Id { get; set; }

    public long IcccincidentId { get; set; }

    public long SaaedIncidentId { get; set; }

    public int Icccservice { get; set; }
}
