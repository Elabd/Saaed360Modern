using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityAssignment
{
    public long ActivityId { get; set; }

    public long ItemId { get; set; }

    public long DispatcherId { get; set; }
}
