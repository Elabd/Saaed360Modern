using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewIncidentNew
{
    public long IncidentId { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public double? IncidentLatitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public string? IncidentType { get; set; }

    public int? IncidentPrioirtyId { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public int IncidentStatusId { get; set; }

    public string? IncidentStatusCode { get; set; }

    public long TelephoneCall { get; set; }

    public string? Owner { get; set; }

    public long? OrganizationId { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public long? SectorId { get; set; }

    public string? SectorName { get; set; }

    public string FirstCallerContact { get; set; } = null!;

    public string? CallerName { get; set; }

    public string? PatrolCode { get; set; }

    public long? PatrolSectorId { get; set; }

    public string? PatrolSectorName { get; set; }

    public string? PatrolStatusCode { get; set; }

    public string MapStatusIcon { get; set; } = null!;

    public string? SupportNames { get; set; }

    public bool? IsDeliveredToStation { get; set; }

    public bool? IsDelayed { get; set; }

    public bool? AutomaticIncident { get; set; }
}
