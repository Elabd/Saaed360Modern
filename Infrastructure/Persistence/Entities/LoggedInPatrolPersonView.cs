using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class LoggedInPatrolPersonView
{
    public long? ItemId { get; set; }

    public long PersonId { get; set; }

    public string? FirstName { get; set; }

    public string UserName { get; set; } = null!;
}
