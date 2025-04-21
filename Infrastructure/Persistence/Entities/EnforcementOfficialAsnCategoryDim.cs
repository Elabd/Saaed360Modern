using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EnforcementOfficialAsnCategoryDim
{
    public int EnforcementOfficialAsnCategoryId { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public virtual ICollection<EnforcementOfficial> EnforcementOfficials { get; set; } = new List<EnforcementOfficial>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
