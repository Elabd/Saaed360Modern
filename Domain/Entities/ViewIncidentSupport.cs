using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewIncidentSupport
{
    public long IncidentId { get; set; }

    public Guid? IncWf { get; set; }

    public long SupportRequestId { get; set; }

    public Guid? Srwf { get; set; }

    public int SupportStatusId { get; set; }

    public long SupportRequestPatrolId { get; set; }

    public Guid? Srpwf { get; set; }

    public long? SpstatusId { get; set; }

    public long OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public int? OrganizationCategoryId { get; set; }
}
