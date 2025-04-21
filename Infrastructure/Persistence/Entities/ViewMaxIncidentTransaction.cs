using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewMaxIncidentTransaction
{
    public long? TransationId { get; set; }

    public long IncidentId { get; set; }
}
