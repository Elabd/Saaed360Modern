using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewIncidentDetailForCompromise
{
    public string? IncidentGeneratedNumber { get; set; }

    public long ActivityId { get; set; }

    public string? IncidentDescription { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public long SourceId { get; set; }

    public bool Isadp { get; set; }

    public long AreaId { get; set; }

    public long EmirateId { get; set; }
}
