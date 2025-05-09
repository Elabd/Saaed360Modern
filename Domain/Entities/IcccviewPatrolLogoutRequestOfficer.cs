using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class IcccviewPatrolLogoutRequestOfficer
{
    public long LogoutRequestId { get; set; }

    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string Description { get; set; } = null!;
}
