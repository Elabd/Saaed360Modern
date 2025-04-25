using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class CityDim
{
    public long CityId { get; set; }

    public string CityName { get; set; } = null!;

    public string? CityCode { get; set; }

    public long EmirateId { get; set; }

    public virtual ICollection<AccidentAreaCategorization> AccidentAreaCategorizations { get; set; } = new List<AccidentAreaCategorization>();

    public virtual ICollection<CommissionArea> CommissionAreas { get; set; } = new List<CommissionArea>();

    public virtual EmirateDim Emirate { get; set; } = null!;

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ICollection<MobileUser> MobileUsers { get; set; } = new List<MobileUser>();

    public virtual ICollection<ReportAreaDim> ReportAreaDims { get; set; } = new List<ReportAreaDim>();

    public virtual ICollection<SecuritySituation> SecuritySituations { get; set; } = new List<SecuritySituation>();

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
