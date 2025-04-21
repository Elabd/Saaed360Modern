using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewSupporCreator
{
    public long IncidentId { get; set; }

    public long SupportRequestId { get; set; }

    public long SupportRequestPatrolId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public long PersonId { get; set; }
}
