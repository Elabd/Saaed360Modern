using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccpoliceIncident
{
    public long Id { get; set; }

    public string? Icccnumber { get; set; }

    public bool? IsSaved { get; set; }

    public long? ControlCenterId { get; set; }

    public string IncidentObj { get; set; } = null!;

    public DateTime CreatedDateTime { get; set; }

    public long CreatedBy { get; set; }

    public virtual Person CreatedByNavigation { get; set; } = null!;
}
