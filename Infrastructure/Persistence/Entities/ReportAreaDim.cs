using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportAreaDim
{
    public long AreaId { get; set; }

    public string AreaName { get; set; } = null!;

    public string? AreaCode { get; set; }

    public long CityId { get; set; }

    public virtual CityDim City { get; set; } = null!;

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ICollection<SectorDim> SectorDims { get; set; } = new List<SectorDim>();

    public virtual ICollection<SecuritySituation> SecuritySituations { get; set; } = new List<SecuritySituation>();

    public virtual ICollection<Violation> Violations { get; set; } = new List<Violation>();
}
