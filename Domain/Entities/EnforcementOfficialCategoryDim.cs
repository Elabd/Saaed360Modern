using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EnforcementOfficialCategoryDim
{
    public int EnforcementOfficialCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<EnforcementOfficial> EnforcementOfficials { get; set; } = new List<EnforcementOfficial>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
