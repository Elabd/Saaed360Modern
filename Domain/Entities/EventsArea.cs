using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsArea
{
    public long EventAreaId { get; set; }

    public string? AreaName { get; set; }

    public string? Description { get; set; }

    public long? EventId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public string? SectorName { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual ICollection<EventsMissionAssignment> EventsMissionAssignments { get; set; } = new List<EventsMissionAssignment>();
}
