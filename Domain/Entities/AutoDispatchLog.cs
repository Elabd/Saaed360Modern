using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AutoDispatchLog
{
    public long Id { get; set; }

    public long ActivityId { get; set; }

    public long PatrolId { get; set; }

    public DateTime DispatchTime { get; set; }

    public double Distance { get; set; }

    public long CreatedBy { get; set; }

    public double AccidentLatitude { get; set; }

    public double AccidentLongitude { get; set; }

    public double PatrolLatitude { get; set; }

    public double PatrolLongitude { get; set; }

    public long AutoDispatchConfId { get; set; }

    public string? BusyPatrols { get; set; }

    public string? AvailablePatrols { get; set; }
}
