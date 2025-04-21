using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class RspDamagedLevelDim
{
    public long RspDamagedLevelId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RspReportBasicDetail> RspReportBasicDetails { get; set; } = new List<RspReportBasicDetail>();
}
