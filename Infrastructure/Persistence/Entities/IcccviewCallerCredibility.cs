using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewCallerCredibility
{
    public long PersonId { get; set; }

    public int? TotalCalls { get; set; }

    public int FakeCalls { get; set; }

    public decimal? Credibility { get; set; }
}
