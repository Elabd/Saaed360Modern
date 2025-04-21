using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Saaed360ViewIncidentList
{
    public long? RowNo { get; set; }

    public long IncidentId { get; set; }

    public long TelephoneCall { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public bool? IsDelayed { get; set; }

    public int IncidentStatusId { get; set; }

    public int? IncidentPrioirtyId { get; set; }

    public long? OrganizationId { get; set; }

    public double? IncidentLatitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public long AreaId { get; set; }

    public string? AreaName { get; set; }

    public long? SectorId { get; set; }

    public string? SectorName { get; set; }

    public string? PatrolCode { get; set; }

    public string? PatrolStatusCode { get; set; }

    public string? PatrolStatus { get; set; }

    public string? FirstCallerContact { get; set; }

    public string MapStatusIcon { get; set; } = null!;
}
