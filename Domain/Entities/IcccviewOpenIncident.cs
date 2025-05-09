using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewOpenIncident
{
    public long IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public DateTime? IncidentCreatedDate { get; set; }

    public Guid? WorkFlowGuid { get; set; }
}
