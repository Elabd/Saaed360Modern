using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Saaed360ViewDispatcherPatrol
{
    public Guid? Identifier { get; set; }

    public long OrganizationId { get; set; }

    public long? AreaId { get; set; }

    public long PatrolId { get; set; }

    public long? PatrolAssignmentId { get; set; }

    public bool? IsAvailable { get; set; }

    public long StatusId { get; set; }

    public string? StatusDescription { get; set; }

    public string DeviceCode { get; set; } = null!;
}
