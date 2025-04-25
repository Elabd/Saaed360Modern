using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewIncidentConvertToStationReason
{
    public long IncidentId { get; set; }

    public string? TransferToStationRequest { get; set; }
}
