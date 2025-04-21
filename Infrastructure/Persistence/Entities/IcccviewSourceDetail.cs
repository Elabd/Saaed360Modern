using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class IcccviewSourceDetail
{
    public long ActivityId { get; set; }

    public string? AdpNumber { get; set; }

    public DateTime? AdpDate { get; set; }

    public long SourceId { get; set; }

    public string? SourceName { get; set; }

    public long SourceDetailId { get; set; }
}
