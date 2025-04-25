using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsSupervisor
{
    public long EventSupervisorId { get; set; }

    public long? PersonId { get; set; }

    public long? EventId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public bool? IsDeteted { get; set; }

    public DateTime? ModificationDateTime { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Event? Event { get; set; }

    public virtual Person? Person { get; set; }
}
