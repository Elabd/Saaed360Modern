using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentConvertToStationReason
{
    public long IncidentId { get; set; }

    public string? TransferToStationRequest { get; set; }
}
