using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsSourceDim
{
    public int EventSourceId { get; set; }

    public string Description { get; set; } = null!;

    public string? EnDescription { get; set; }

    public virtual ICollection<EventSourcePerson> EventSourcePeople { get; set; } = new List<EventSourcePerson>();

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
