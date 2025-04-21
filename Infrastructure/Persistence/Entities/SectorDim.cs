using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class SectorDim
{
    public long SectorId { get; set; }

    public string SectorName { get; set; } = null!;

    public string? SectorCode { get; set; }

    public long ReportAreaId { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual ReportAreaDim ReportArea { get; set; } = null!;

    public virtual ICollection<StreetDim> StreetDims { get; set; } = new List<StreetDim>();
}
