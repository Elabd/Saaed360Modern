using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EventsStatusLog
{
    public long EventStatusLogId { get; set; }

    public long? EventId { get; set; }

    public int? EventStatusId { get; set; }

    public long? CreatedBy { get; set; }

    public DateTime? CreationDateTime { get; set; }

    public virtual Person? CreatedByNavigation { get; set; }

    public virtual Event? Event { get; set; }

    public virtual EventsStatusDim? EventStatus { get; set; }
}
