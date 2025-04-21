using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentCompromise
{
    public long CompromiseId { get; set; }

    public long IncidentId { get; set; }

    public string? IncidentGeneratedNumber { get; set; }
}
