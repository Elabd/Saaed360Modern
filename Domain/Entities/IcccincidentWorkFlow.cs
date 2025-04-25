using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccincidentWorkFlow
{
    public long? RowNo { get; set; }

    public Guid? IncworkFlowGuid { get; set; }

    public long IncidentId { get; set; }

    public long? ActivityId { get; set; }

    public long? ActivityItemId { get; set; }

    public long? ItemId { get; set; }

    public DateTime? AssignTime { get; set; }

    public long? OrganizationItemId { get; set; }

    public string? ActivityCategory { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public string? PlateNumber { get; set; }

    public string? Organization { get; set; }

    public string? Status { get; set; }

    public string? StatusCode { get; set; }

    public int IncidentStatusId { get; set; }

    public string? IncidentStatusCode { get; set; }

    public string? IncidentStatusDescription { get; set; }

    public long? OrganizationId { get; set; }

    public long? ItemStatusId { get; set; }

    public string? ItemStatusCode { get; set; }

    public string? OrganizationCategoryCode { get; set; }
}
