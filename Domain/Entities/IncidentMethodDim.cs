using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IncidentMethodDim
{
    public int IncidentMethodId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Incident> Incidents { get; set; } = new List<Incident>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
