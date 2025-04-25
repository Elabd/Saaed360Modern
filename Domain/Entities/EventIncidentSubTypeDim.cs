using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventIncidentSubTypeDim
{
    public long Id { get; set; }

    public string? DescriptionAr { get; set; }

    public string? DescriptionEn { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public long? CriticalityLevelId { get; set; }

    public long? IncidentTypeId { get; set; }

    public virtual EventIncidentCriticalityLevelDim? CriticalityLevel { get; set; }

    public virtual ICollection<EventIncidentActionDim> EventIncidentActionDims { get; set; } = new List<EventIncidentActionDim>();

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual EventIncidentTypeDim? IncidentType { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
