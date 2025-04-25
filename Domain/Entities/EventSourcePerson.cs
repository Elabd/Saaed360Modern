using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventSourcePerson
{
    public long Id { get; set; }

    public int EventSourceId { get; set; }

    public long PersonId { get; set; }

    public bool? IsDeleted { get; set; }

    public virtual EventsSourceDim EventSource { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
