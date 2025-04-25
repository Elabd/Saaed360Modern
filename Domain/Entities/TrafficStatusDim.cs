using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TrafficStatusDim
{
    public long TrafficStatusId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedDateTime { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RspReportBasicDetail> RspReportBasicDetails { get; set; } = new List<RspReportBasicDetail>();
}
