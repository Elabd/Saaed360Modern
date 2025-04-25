using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class FacilityBedAssignmentDim
{
    public int FacilityBedAssignmentId { get; set; }

    public string Code { get; set; } = null!;

    public string? Building { get; set; }

    public string? BuildingCode { get; set; }

    public string? Block { get; set; }

    public string? BlockCode { get; set; }

    public string? Cell { get; set; }

    public string? Bed { get; set; }

    public string? CellCode { get; set; }

    public string? BedCode { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual RowStatusDim? RowStatus { get; set; }

    public virtual ICollection<Supervision> Supervisions { get; set; } = new List<Supervision>();
}
