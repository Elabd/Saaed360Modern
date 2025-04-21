using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewActivityGroupGisreport
{
    public long ActivityAreaGroupId { get; set; }

    public long ActivityId { get; set; }

    public int? AreaGroupId { get; set; }

    public DateTime CreationDate { get; set; }

    public bool IsSent { get; set; }

    public int NumRetry { get; set; }

    public DateTime? LastRetryDate { get; set; }

    public DateTime? SendDate { get; set; }

    public string? ServiceResponse { get; set; }

    public string GroupName { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public int? MaxResponseTimeInSecs { get; set; }
}
