using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportReasonDim
{
    public int ReportReasonId { get; set; }

    public string? Reason { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<VehicleDatum> VehicleData { get; set; } = new List<VehicleDatum>();
}
