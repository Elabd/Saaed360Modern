using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class DrivingCmvdim
{
    public int DrivingCmvid { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<DrivingIncident> DrivingIncidents { get; set; } = new List<DrivingIncident>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
