using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewIncidentPopupIncident
{
    public long ActivityId { get; set; }

    public string? IncidentNumber { get; set; }

    public string? IncidentStatus { get; set; }

    public int StatusId { get; set; }
}
