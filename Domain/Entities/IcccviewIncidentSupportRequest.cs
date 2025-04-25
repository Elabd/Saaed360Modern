using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewIncidentSupportRequest
{
    public long IncidentId { get; set; }

    public long SupportRequestId { get; set; }

    public long SupportRequestPatrolId { get; set; }

    public int SupportStatusId { get; set; }

    public long? SupportRequestPatrolStatusId { get; set; }

    public Guid? SupportRequestWorkflowGuid { get; set; }

    public Guid? SupportRequestPatrolWorkflowGuid { get; set; }

    public long OrganizationId { get; set; }

    public string? OrganizationName { get; set; }
}
