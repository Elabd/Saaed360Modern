using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReportModificationResponsibilityDim
{
    public int ResponsibilityId { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public byte[]? TimeStamp { get; set; }

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();
}
