using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class ReportSerializedDto
{
    public long ReportId { get; set; }

    public string ReportNumber { get; set; } = null!;

    public string? ReportDtostr { get; set; }

    public DateTime CreationTime { get; set; }
}
