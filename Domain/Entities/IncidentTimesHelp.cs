using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentTimesHelp
{
    public long ActivityId { get; set; }

    public DateTime? Ad { get; set; }

    public DateTime? Ak { get; set; }

    public DateTime? Ar1 { get; set; }

    public DateTime? Ar2 { get; set; }

    public DateTime? Sarc { get; set; }

    public DateTime? Earc { get; set; }

    public DateTime? Cl { get; set; }

    public DateTime? Ca { get; set; }

    public DateTime? ClosedIncident { get; set; }
}
