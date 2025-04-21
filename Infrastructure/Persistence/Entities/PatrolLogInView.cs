using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PatrolLogInView
{
    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public long SectorId { get; set; }

    public string? SectorName { get; set; }
}
