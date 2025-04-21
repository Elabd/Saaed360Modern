using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IncidentFactorDim
{
    public int IncidentFactorId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? NiemtypeName { get; set; }

    public string? Niem { get; set; }

    public string? Category { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<IncidentFactor> IncidentFactors { get; set; } = new List<IncidentFactor>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
