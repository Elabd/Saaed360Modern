using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class PersonHairAppearanceDim
{
    public int PersonHairAppearanceId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<PersonPhysicalDetail> PersonPhysicalDetails { get; set; } = new List<PersonPhysicalDetail>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
