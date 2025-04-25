using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class EservicesSupervisor
{
    public long Id { get; set; }

    public string? Email { get; set; }

    public bool IsAbuDhabi { get; set; }
}

