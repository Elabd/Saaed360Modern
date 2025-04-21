using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewPatrolsInMission
{
    public long ItemId { get; set; }

    public long RequestId { get; set; }

    public DateTime? ActivityDate { get; set; }

    public string? Code { get; set; }
}
