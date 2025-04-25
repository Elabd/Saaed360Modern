using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportAmbulance
{
    public long Id { get; set; }

    public int ReportId { get; set; }

    public bool IsNeedAmbulance { get; set; }

    public DateTime? AmbulanceDate { get; set; }

    public string? InjuredNames { get; set; }

    public virtual Report Report { get; set; } = null!;
}
