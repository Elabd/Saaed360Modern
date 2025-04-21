using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PhysicalFeatureHandicapDim
{
    public int PhysicalFeatureHandicapId { get; set; }

    public string? Description { get; set; }

    public string? Ncic { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonPhysicalFeature> PersonPhysicalFeatures { get; set; } = new List<PersonPhysicalFeature>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
