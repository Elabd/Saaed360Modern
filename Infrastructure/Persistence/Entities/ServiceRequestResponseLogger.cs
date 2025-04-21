using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ServiceRequestResponseLogger
{
    public long LogId { get; set; }

    public string? RequestXml { get; set; }

    public string? ResponseXml { get; set; }

    public string? IncidentNumber { get; set; }

    public string? AccidentNumber { get; set; }

    public long? RequestedBy { get; set; }

    public DateTime? RequestedTimeStamp { get; set; }

    public virtual Person? RequestedByNavigation { get; set; }
}

