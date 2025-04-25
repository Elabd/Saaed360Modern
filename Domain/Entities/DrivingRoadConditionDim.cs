using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DrivingRoadConditionDim
{
    public int DrivingRoadConditionId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<DrivingIncident> DrivingIncidents { get; set; } = new List<DrivingIncident>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
