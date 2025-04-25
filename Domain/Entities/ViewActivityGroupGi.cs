using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ViewActivityGroupGi
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

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? GroupName { get; set; }

    public string? GroupCode { get; set; }

    public long EmirateId { get; set; }
}
