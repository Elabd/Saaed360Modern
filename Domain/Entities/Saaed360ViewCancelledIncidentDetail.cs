using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Saaed360ViewCancelledIncidentDetail
{
    public long IncidentId { get; set; }

    public long? TelephoneCallId { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public long? EmirateId { get; set; }

    public long? AreaId { get; set; }

    public long? SectorId { get; set; }

    public string? SectorName { get; set; }

    public long? LandMarkId { get; set; }

    public double? IncidentLatitude { get; set; }

    public double? IncidentLongitude { get; set; }

    public string? IncidentAddress { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public int? IncidentPrioirtyId { get; set; }

    public int? IncidentTypeId { get; set; }

    public bool? IsConvertedToPoliceStation { get; set; }

    public bool? IsDeliveredToPoliceStation { get; set; }

    public Guid? ConvertToStationWorkFlow { get; set; }

    public string? ConvertToStationReason { get; set; }

    public string? ConvertToStationOrganization { get; set; }

    public Guid? WorkFlowGuid { get; set; }

    public bool? IsDelayed { get; set; }

    public int IncidentStatusId { get; set; }

    public long? OrganizationId { get; set; }

    public string? OrganizationName { get; set; }

    public long? SourceId { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public string? MapStatusIcon { get; set; }
}
