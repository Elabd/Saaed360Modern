using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentActionDim
{
    public long Id { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public long? EventIncidentSubTypeId { get; set; }

    public virtual ICollection<EventIncidentAction> EventIncidentActions { get; set; } = new List<EventIncidentAction>();

    public virtual EventIncidentSubTypeDim? EventIncidentSubType { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }
}
