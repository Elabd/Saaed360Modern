using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentListObj
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
}
