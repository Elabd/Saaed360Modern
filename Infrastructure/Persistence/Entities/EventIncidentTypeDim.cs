using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentTypeDim
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<EventIncidentSubTypeDim> EventIncidentSubTypeDims { get; set; } = new List<EventIncidentSubTypeDim>();

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
