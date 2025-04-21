using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SaaedIncidentSupportsforMap
{
    public long ActivityId { get; set; }

    public string? Name { get; set; }

    public DateTime? ModifiedDateTimeStamp { get; set; }

    public string? SupportStatus { get; set; }

    public bool? IsExternal { get; set; }

    public bool? IsFinished { get; set; }

    public bool? IsNotify { get; set; }
}
