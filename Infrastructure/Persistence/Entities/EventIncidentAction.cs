using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentAction
{
    public long Id { get; set; }

    public long IncidentId { get; set; }

    public long ActionId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModificationBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual EventIncidentActionDim Action { get; set; } = null!;

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual EventIncident Incident { get; set; } = null!;

    public virtual Person? ModificationByNavigation { get; set; }
}
