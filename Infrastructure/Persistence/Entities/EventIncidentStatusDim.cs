using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentStatusDim
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Code { get; set; } = null!;

    public virtual ICollection<EventIncident> EventIncidents { get; set; } = new List<EventIncident>();

    public virtual ICollection<EventIncidentsStatusLog> EventIncidentsStatusLogs { get; set; } = new List<EventIncidentsStatusLog>();
}
