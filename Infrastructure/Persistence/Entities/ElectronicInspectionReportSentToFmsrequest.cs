using System;
using System.Collections.Generic;

namespace Infrastructure.Persistence.Entities;

public partial class ElectronicInspectionReportSentToFmsrequest
{
    public long Id { get; set; }

    public long? ReportId { get; set; }

    public string? Description { get; set; }

    public string? Error { get; set; }

    public bool? Status { get; set; }

    public DateTime? RequestDate { get; set; }
}
