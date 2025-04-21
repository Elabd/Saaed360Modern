using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ReuploadReportsReasonsDim
{
    public long ReasonId { get; set; }

    public string ReasonDescription { get; set; } = null!;

    public string ReasonValue { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
