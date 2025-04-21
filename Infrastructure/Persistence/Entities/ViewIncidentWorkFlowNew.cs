using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentWorkFlowNew
{
    public long IncidentId { get; set; }

    public Guid? IncworkFlowGuid { get; set; }

    public int ActivityCategoryId { get; set; }

    public long ActivityId { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public long? ActivityItemId { get; set; }
}
