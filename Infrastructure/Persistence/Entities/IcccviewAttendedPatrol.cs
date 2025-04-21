using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewAttendedPatrol
{
    public long? LoginId { get; set; }

    public string? PatrolCode { get; set; }

    public long PatrolId { get; set; }

    public DateTime? LoginTime { get; set; }

    public bool? LoginAcknowledged { get; set; }

    public DateTime? LoginAcknowledgeDate { get; set; }

    public DateTime? FinalDismissTime { get; set; }

    public DateTime? TempLogoutTime { get; set; }

    public DateTime? ReturnBackTime { get; set; }
}
