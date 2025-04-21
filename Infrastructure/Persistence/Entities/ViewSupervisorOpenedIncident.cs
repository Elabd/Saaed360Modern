using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewSupervisorOpenedIncident
{
    public long IncidentId { get; set; }

    public string? IncidentDesription { get; set; }

    public string? IncidentGeneratedNumber { get; set; }

    public int? ServiceCallIncidentTypeId { get; set; }

    public string? IncidentType { get; set; }

    public int? IncidentPrioirtyId { get; set; }

    public DateTime? IncidentDateTime { get; set; }

    public int IncidentStatusId { get; set; }

    public string? IncidentStatusCode { get; set; }

    public long TelephoneCall { get; set; }

    public DateTime? RingingTime { get; set; }

    public long AreaId { get; set; }

    public long SourceId { get; set; }

    public DateTime? AdpDate { get; set; }

    public bool? IsCompleted { get; set; }

    public DateTime? ActivityStartDate { get; set; }
}
