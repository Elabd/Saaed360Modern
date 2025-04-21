using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EventIncidentsLog
{
    public long Id { get; set; }

    public long EventIncidentId { get; set; }

    public int StatusId { get; set; }

    public DateTime? CreationDate { get; set; }

    public long? CreatedBy { get; set; }
}
