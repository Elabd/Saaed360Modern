using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsStatusDim
{
    public int EventsStatusId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();

    public virtual ICollection<EventsStatusLog> EventsStatusLogs { get; set; } = new List<EventsStatusLog>();
}
