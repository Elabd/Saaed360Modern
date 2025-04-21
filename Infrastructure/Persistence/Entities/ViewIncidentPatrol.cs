using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentPatrol
{
    public long ActivityId { get; set; }

    public long DispatchActivityId { get; set; }

    public string? SerialIdentification { get; set; }

    public long ItemId { get; set; }

    public long? SectorId { get; set; }

    public string? SectorName { get; set; }

    public string? PatrolStatusCode { get; set; }

    public long ActivityItemId { get; set; }
}
