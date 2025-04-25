using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ImpoundPatrolIdMapping
{
    public long Id { get; set; }

    public long ImpoundPatrolId { get; set; }

    public long PatrolId { get; set; }
}
