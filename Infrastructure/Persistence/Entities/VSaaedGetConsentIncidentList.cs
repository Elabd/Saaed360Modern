using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class VSaaedGetConsentIncidentList
{
    public long CompromiseId { get; set; }

    public string? IncidentDescription { get; set; }

    public DateTime? IncidentDate { get; set; }

    public string? CompromiseNumber { get; set; }

    public long? Sourceid { get; set; }

    public string? Sourcename { get; set; }

    public string? Adpnumber { get; set; }

    public DateTime? Adpdate { get; set; }

    public long? IncidentId { get; set; }

    public string? IncidentNumber { get; set; }

    public string CallerName { get; set; } = null!;

    public string? CallerNumber { get; set; }

    public long ControlCenterId { get; set; }

    public string? ControlCenterName { get; set; }

    public long AreaId { get; set; }

    public string? Area { get; set; }

    public long? EmirateId { get; set; }

    public string? Emirate { get; set; }

    public string CallerTakerName { get; set; } = null!;

    public long? CallTakerId { get; set; }

    public string? Address { get; set; }
}
