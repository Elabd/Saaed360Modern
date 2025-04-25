using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventIncidentComment
{
    public long Id { get; set; }

    public long IncidentId { get; set; }

    public string? Comment { get; set; }

    public bool? IsInternal { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? ModificationBy { get; set; }

    public DateTime? ModificationDate { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual ICollection<EventIncidentImage> EventIncidentImages { get; set; } = new List<EventIncidentImage>();

    public virtual EventIncident Incident { get; set; } = null!;

    public virtual Person? ModificationByNavigation { get; set; }
}
