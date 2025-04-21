using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportDocument
{
    public long Id { get; set; }

    public long ReportId { get; set; }

    public long UserId { get; set; }

    public DateTime CreationTime { get; set; }

    public string DocPath { get; set; } = null!;

    public string? DocName { get; set; }

    public virtual ElectronicInspectionReport Report { get; set; } = null!;
}
