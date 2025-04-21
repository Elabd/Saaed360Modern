using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ModifiedReport
{
    public int? ReportId { get; set; }

    public int? ModificationType { get; set; }
}
