using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewPatrolLogoutRequest
{
    public long LogoutRequestId { get; set; }

    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public DateTime? LoginDate { get; set; }

    public int? LogoutRequestType { get; set; }

    public string? LogoutRequestTypeDescription { get; set; }
}
