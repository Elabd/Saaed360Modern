using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ImpoundPatrolIdMapping
{
    public long Id { get; set; }

    public long ImpoundPatrolId { get; set; }

    public long PatrolId { get; set; }
}
