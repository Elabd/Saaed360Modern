using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class PersonBuildDim
{
    public int PersonBuildId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual ICollection<PhysicalAppearanceHistory> PhysicalAppearanceHistories { get; set; } = new List<PhysicalAppearanceHistory>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
