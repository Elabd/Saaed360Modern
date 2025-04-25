using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewPatrolLoggedStatus
{
    public long PatrolId { get; set; }

    public string? PatrolCode { get; set; }

    public bool? LoggedIn { get; set; }
}
