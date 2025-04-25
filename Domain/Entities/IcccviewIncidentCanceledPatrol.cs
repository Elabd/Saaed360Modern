using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewIncidentCanceledPatrol
{
    public long PatrolId { get; set; }

    public long PatrolAssignmentId { get; set; }

    public long IncidentId { get; set; }

    public string? ActivityDescription { get; set; }

    public DateTime? ActivityDate { get; set; }

    public long OrganizationId { get; set; }

    public string? DispatcherOrganizationName { get; set; }

    public string? DeviceCode { get; set; }

    public string? PatrolCode { get; set; }

    public string? PatrolStatus { get; set; }

    public string? PatrolstatusDescription { get; set; }

    public string? IncidentStatus { get; set; }
}
