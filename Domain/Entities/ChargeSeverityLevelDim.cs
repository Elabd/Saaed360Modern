using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ChargeSeverityLevelDim
{
    public int ChargeSeverityLevelId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<Charge> Charges { get; set; } = new List<Charge>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
