using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewIncidentCall
{
    public long IncidentId { get; set; }

    public string? ContactName { get; set; }

    public string ContactInformation { get; set; } = null!;
}
