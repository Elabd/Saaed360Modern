using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class CancelReasonDim
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Desc { get; set; }

    public string? Code { get; set; }

    public byte[]? TimeSamp { get; set; }

    public virtual ICollection<ReportRequest> ReportRequests { get; set; } = new List<ReportRequest>();
}
