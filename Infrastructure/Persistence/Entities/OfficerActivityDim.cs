using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class OfficerActivityDim
{
    public int OfficerActivityId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<OfficerInjury> OfficerInjuries { get; set; } = new List<OfficerInjury>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
