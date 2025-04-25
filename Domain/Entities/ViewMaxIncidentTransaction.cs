using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewMaxIncidentTransaction
{
    public long? TransationId { get; set; }

    public long IncidentId { get; set; }
}
