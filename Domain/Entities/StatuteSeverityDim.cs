using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class StatuteSeverityDim
{
    public int StatuteSeverityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<IncidentStatute> IncidentStatutes { get; set; } = new List<IncidentStatute>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
