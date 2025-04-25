using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class DetectLocationLog
{
    public long Id { get; set; }

    public long IcccrequestId { get; set; }

    public long AreaId { get; set; }

    public string CustomerMobileNumber { get; set; } = null!;

    public DateTime SendToCustomerTime { get; set; }

    public bool IsCustomerReplied { get; set; }

    public DateTime? CustomerReplyTime { get; set; }

    public long? SaaedIncidentId { get; set; }

    public bool? IsAfterCreateIncident { get; set; }

    public DateTime CreationTime { get; set; }

    public double? OldLat { get; set; }

    public double? OldLon { get; set; }

    public long? OldSaaedArea { get; set; }

    public double? NewLat { get; set; }

    public double? NewLon { get; set; }

    public long? NewSaaedArea { get; set; }

    public string? Note { get; set; }
}
