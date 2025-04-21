using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentsStatusLog
{
    public long Id { get; set; }

    public long? EventIncidentId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public int? StatusId { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventIncident? EventIncident { get; set; }

    public virtual EventIncidentStatusDim? Status { get; set; }
}
