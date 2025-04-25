using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewClosedIncidentNew
{
    public long IncidentId { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public int StatusId { get; set; }

    public int? IncidentPrioirtyId { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public string? Owner { get; set; }

    public long OrganizationId { get; set; }

    public long AreaId { get; set; }

    public string? PatrolCode { get; set; }

    public long? PatrolSectorId { get; set; }

    public string? PatrolSectorName { get; set; }

    public string? PatrolStatusCode { get; set; }

    public bool? IsAutoDispatch { get; set; }
}
