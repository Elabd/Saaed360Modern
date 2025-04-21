using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewAttendedPatrolOfficer
{
    public long LoginId { get; set; }

    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MiddleName { get; set; }

    public string Description { get; set; } = null!;
}
