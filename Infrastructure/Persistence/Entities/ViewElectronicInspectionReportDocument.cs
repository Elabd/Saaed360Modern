using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ViewElectronicInspectionReportDocument
{
    public string DocPath { get; set; } = null!;

    public string? DocName { get; set; }

    public DateTime CreationTime { get; set; }

    public string PersonName { get; set; } = null!;

    public long ReportId { get; set; }
}
