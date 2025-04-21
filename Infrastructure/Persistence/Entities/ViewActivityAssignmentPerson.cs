using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityAssignmentPerson
{
    public long ActivityId { get; set; }

    public long TrafficExpertId { get; set; }
}
