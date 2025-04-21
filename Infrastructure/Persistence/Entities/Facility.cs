using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class Facility
{
    public long OrganizationId { get; set; }

    public int FacilityCategoryId { get; set; }

    public bool FacilityCommercialIndicator { get; set; }

    public int FacilityCapacity { get; set; }

    public bool FacilityJuvenileIndicator { get; set; }

    public int FacilityMemberCategoryId { get; set; }

    public int FacilitySecurityLevelId { get; set; }

    public virtual FacilityCategoryDim FacilityCategory { get; set; } = null!;

    public virtual FacilityMemberCategoryDim FacilityMemberCategory { get; set; } = null!;

    public virtual FacilitySecurityLevelDim FacilitySecurityLevel { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;
}
