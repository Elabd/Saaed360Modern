using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RoadSurfaceDim
{
    public int RoadSurfaceId { get; set; }

    public string? Description { get; set; }

    public DateTime VersionDateTime { get; set; }

    public int? RowStatusId { get; set; }

    public bool? IsDeleted { get; set; }

    public byte[]? TimeStamp { get; set; }

    public bool IsDefaultForReportConstruction { get; set; }

    public virtual ICollection<MdtaccidentBasicDetail> MdtaccidentBasicDetails { get; set; } = new List<MdtaccidentBasicDetail>();

    public virtual RowStatusDim? RowStatus { get; set; }
}
