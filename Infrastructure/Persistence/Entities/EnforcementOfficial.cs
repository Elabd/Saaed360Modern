using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class EnforcementOfficial
{
    public long PersonId { get; set; }

    public int EnforcementOfficialAsnCategoryId { get; set; }

    public int EnforcementOfficialCategoryId { get; set; }

    public string EnforcementOfficialBadgeIdentification { get; set; } = null!;

    public string EnforcementOfficialPostLicenseIdent { get; set; } = null!;

    public string EnforcementOfficialUnit { get; set; } = null!;

    public virtual EnforcementOfficialAsnCategoryDim EnforcementOfficialAsnCategory { get; set; } = null!;

    public virtual EnforcementOfficialCategoryDim EnforcementOfficialCategory { get; set; } = null!;

    public virtual Person Person { get; set; } = null!;
}
