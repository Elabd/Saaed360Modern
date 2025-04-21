using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityAssignmentSimple
{
    public long ActivityId { get; set; }

    public long ItemId { get; set; }
}
