using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IdentityTheftCategoryDim
{
    public int IdentityTheftCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Ncic { get; set; }

    public string? Reference { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<IdentityTheftIncident> IdentityTheftIncidents { get; set; } = new List<IdentityTheftIncident>();

    public virtual RowStatusDim? RowStatus { get; set; }
}

