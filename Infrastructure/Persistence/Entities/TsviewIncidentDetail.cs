using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class TsviewIncidentDetail
{
    public long? IncidentId { get; set; }

    public long TelephoneCallId { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public string? Emirate { get; set; }

    public string? Area { get; set; }

    public string? SectorName { get; set; }

    public string? LandMark { get; set; }

    public long EmirateId { get; set; }

    public long AreaId { get; set; }

    public long? SectorId { get; set; }

    public long? LandMarkId { get; set; }

    public double? IncidentLatitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public string? IncidentAddress { get; set; }

    public string? IncidentType { get; set; }

    public string? Priority { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public string? ConvertToStationReason { get; set; }

    public string? ConvertToStationOrganization { get; set; }

    public bool? IsDelayed { get; set; }

    public int? IncidentStatusId { get; set; }

    public long? OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public long? SourceDetailId { get; set; }

    public long? SourceId { get; set; }

    public string? AdpNumber { get; set; }

    public string? SourceName { get; set; }

    public DateTime? AdpDate { get; set; }

    public bool? IsAml { get; set; }
}
